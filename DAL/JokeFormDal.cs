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

        public string getJokeText (int id)
        {
            using (var conn = CreateConnection())
            {

                var cmd = new OracleCommand(SQL_GET_JOKE_WORDS, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("JOKE_ID", id);
                OracleDataReader dr = cmd.ExecuteReader();
                StringBuilder joke = new StringBuilder();
                int lineIdx = 0;
                while (dr.Read())
                {
                    if((int.Parse(dr["line_index"].ToString()) > lineIdx))
                    {
                        joke.Append("\n");
                        lineIdx++;
                    }
                    joke.Append(dr["text"].ToString());
                }
                    

                return joke.ToString();
            }
        }

        public int getFileId(int jokeId)
        {
            using (var conn = CreateConnection())
            {

                var cmd = new OracleCommand(SQL_GET_FILE_ID, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("ID", jokeId);

                OracleDataReader dr = cmd.ExecuteReader();

                int fileId = int.Parse(dr["file_id"].ToString());
                return fileId;

            }
        }


    }
}
