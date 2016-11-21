﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoadTabDal : BaseDal
    {
        private const string JK_FILE_SEQ = "JK_FILE_SEQ";
        private const string JOKE_SEQ = "JOKE_SEQ";

        private const string SQL_INSERT_JK_FILE = @"
INSERT INTO jk_file 
(id, title, author, rating, source, creation_date, insertion_date)
VALUES
(:ID, :TITLE, :AUTHOR, :RATING, :SOURCE, :CREATION_DATE, sysdate)";

        private const string SQL_INSERT_JOKE = @"
INSERT INTO joke
(id, file_id, joke_index)
VALUES
(:ID, :FILE_ID, :JOKE_INDEX)";

        private const string SQL_INSERT_WORD_IN_JOKE = @"
INSERT INTO word_in_joke
(joke_id, index_in_joke, text, text_for_search, line_index, index_in_line)
VALUES
(:JOKE_ID, {0}, '{1}', '{2}', {3}, {4});";

        public void SaveNewFile(JokeFileInfo info)
        {
            using (var conn = CreateConnection())
            using (var trans = conn.BeginTransaction())
            {
                var fileId = this.NextVal(JK_FILE_SEQ, conn);

                var cmd = new OracleCommand(SQL_INSERT_JK_FILE, conn);

                cmd.Parameters.Add("ID", fileId);
                cmd.Parameters.Add("TITLE", info.Title);
                cmd.Parameters.Add("AUTHOR", info.Author);
                cmd.Parameters.Add("RATING", info.Rating);
                cmd.Parameters.Add("SOURCE", info.Source);
                cmd.Parameters.Add("CREATION_DATE", info.CreationDate);

                var returnVal = cmd.ExecuteNonQuery();

                if (returnVal != 1)
                {
                    throw new Exception("Failed to insert file data");
                }

                int lineIndex = 0;

                for (int i = 0; i < info.Jokes.Count; i++)
                {
                    SaveJoke(info.Jokes[i], fileId, i, ref lineIndex, conn);
                }

                trans.Commit();
            }
        }

        private void SaveJoke(string joke, int fileId, int jokeIndex, ref int lineIndex, OracleConnection conn)
        {
            var cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = SQL_INSERT_JOKE;

            var jokeId = this.NextVal(JOKE_SEQ, conn);

            cmd.Parameters.Add("ID", jokeId);
            cmd.Parameters.Add("FILE_ID", fileId);
            cmd.Parameters.Add("JOKE_INDEX", jokeIndex);

            var returnVal = cmd.ExecuteNonQuery();

            if (returnVal != 1)
            {
                throw new Exception("Failed to insert joke data");
            }

            SaveJokeWords(joke, jokeId, ref lineIndex, conn);
        }

        private void SaveJokeWords(string joke, int jokeId, ref int lineIndex, OracleConnection conn)
        {
            var cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.Parameters.Add("JOKE_ID", jokeId);

            var commandText = new StringBuilder();

            commandText.Append("BEGIN ");

            var lines = joke.Split('\n').ToList();

            foreach (var line in lines)
            {
                var words = joke.Split(' ').ToList();

                for (int i = 0; i < words.Count; i++)
                {
                    commandText.Append(string.Format(
                        SQL_INSERT_WORD_IN_JOKE,
                        i,
                        words[i],
                        StripWord(words[i]).ToUpper(),
                        lineIndex,
                        i));
                }

                lineIndex++;
            }

            commandText.Append("END;");

            cmd.CommandText = commandText.ToString();

            cmd.ExecuteNonQuery();
        }

        private string StripWord(string text)
        {
            int firstIndex = -1;
            int lastIndex = -1;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetterOrDigit(text[i]))
                {
                    firstIndex = i;
                    break;
                }
            }

            if (firstIndex == -1) return string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (char.IsLetterOrDigit(text[i]))
                {
                    lastIndex = i;
                    break;
                }
            }

            return text.Substring(firstIndex, lastIndex - firstIndex + 1);
        }
    }
}
