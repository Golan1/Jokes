using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace DAL
{
    public class FileFormDal : BaseDal
    {

        private const string GET_JOKES_SQL = @"
SELECT LISTAGG(jokes.text, chr(10) || chr(10)) WITHIN GROUP (ORDER BY jokes.joke_index) AS text
FROM(
    SELECT lines.joke_index, LISTAGG(lines.text, chr(10)) WITHIN GROUP(ORDER BY lines.line_index) AS text
    FROM(
        SELECT j.joke_index, wij.line_index, LISTAGG(wij.text, ' ') WITHIN GROUP(ORDER BY wij.index_in_line) AS text
        FROM joke j
        JOIN word_in_joke wij ON j.id = wij.joke_id
        WHERE j.file_id = :FILE_ID
        GROUP BY j.joke_index, wij.line_index
        ORDER BY wij.line_index) lines
    GROUP BY lines.joke_index
    ORDER BY lines.joke_index) jokes";

        public string GetFileText(decimal fileId)
        {
            string text = "";

            using (var conn = CreateConnection())
            {
                var cmd = new OracleCommand(GET_JOKES_SQL, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("FILE_ID", fileId);

                OracleDataReader dr = cmd.ExecuteReader();

                dr.Read();
                text = dr["text"].ToString();

                return text;
            }
        }

        const string SQL_BY_FILE = @"
SELECT wij.*, j.joke_index as JOKE_INDEX
FROM word_in_joke wij
JOIN joke j ON j.id = wij.joke_id
WHERE j.FILE_ID = :FILE_ID
{0}
ORDER BY j.joke_index, wij.index_in_joke";

        const string WHERE_BY_JOKE_INDEX =
@"AND j.joke_index = :JOKE_INDEX
AND wij.index_in_joke = :INDEX_IN_JOKE";

        const string WHERE_BY_LINE_INDEX =
@"AND wij.line_index = :LINE_INDEX
AND wij.index_in_line = :INDEX_IN_LINE";

        private JokesDS.WORD_IN_JOKEDataTable GetWords(OracleCommand cmd)
        {
            using (var conn = CreateConnection())
            {
                cmd.Connection = conn;
                var adapter = new OracleDataAdapter(cmd);
                DS.WORD_IN_JOKE.Clear();
                adapter.Fill(DS.WORD_IN_JOKE);
            }

            return DS.WORD_IN_JOKE;
        }

        public JokesDS.WORD_IN_JOKEDataTable GetWordsFile(decimal fileId)
        {
            var cmd = new OracleCommand(string.Format(SQL_BY_FILE, ""));
            cmd.Parameters.Add("FILED_ID", fileId);

            return GetWords(cmd);
        }

        public JokesDS.WORD_IN_JOKEDataTable GetWordsFileByJokeAndIndex(decimal fileId, decimal jokeIndex, decimal indexInJoke)
        {
            var cmd = new OracleCommand(string.Format(SQL_BY_FILE, WHERE_BY_JOKE_INDEX));
            cmd.Parameters.Add("FILE_ID", fileId);
            cmd.Parameters.Add("JOKE_INDEX", jokeIndex);
            cmd.Parameters.Add("INDEX_IN_JOKE", indexInJoke);

            return GetWords(cmd);
        }

        public JokesDS.WORD_IN_JOKEDataTable GetWordsFileByLineAndIndex(decimal fileId, decimal lineIndex, decimal indexInLine)
        {
            var cmd = new OracleCommand(string.Format(SQL_BY_FILE, WHERE_BY_LINE_INDEX));
            cmd.Parameters.Add("FILE_ID", fileId);
            cmd.Parameters.Add("LINE_INDEX", lineIndex);
            cmd.Parameters.Add("INDEX_IN_LINE", indexInLine);

            return GetWords(cmd);
        }


    }
}
