using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class JokeFormDal : BaseDal
    {
        private const string SQL_GET_JOKE_WORDS = @"
        SELECT text , line_index
        FROM word_in_joke
        WHERE joke_id = :JOKE_ID
        ORDER BY index_in_joke";

        private const string SQL_GET_FILE_ID = @"
        SELECT file_id
        FROM joke
        WHERE id=:ID";

        public string getJokeText(decimal jokeId)
        {
            using (var conn = CreateConnection())
            {

                var cmd = new OracleCommand(SQL_GET_JOKE_WORDS, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("JOKE_ID", jokeId);

                OracleDataReader dr = cmd.ExecuteReader();

                StringBuilder joke = new StringBuilder();

                dr.Read();

                int lineIdx = dr.GetInt32(1);

                joke.Append(dr.GetString(0));

                while (dr.Read())
                {
                    if (dr.GetInt32(1) > lineIdx)
                    {
                        joke.Append(Environment.NewLine);
                        lineIdx++;
                    }
                    else
                    {
                        joke.Append(" ");
                    }

                    joke.Append(dr.GetString(0));
                }

                return joke.ToString();
            }
        }

        public int getFileId(decimal jokeId)
        {
            using (var conn = CreateConnection())
            {

                var cmd = new OracleCommand(SQL_GET_FILE_ID, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("ID", jokeId);

                OracleDataReader dr = cmd.ExecuteReader();

                int fileId = dr.GetInt32(0);
                return fileId;

            }
        }


    }
}
