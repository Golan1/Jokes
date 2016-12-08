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

        public string GetFileText (decimal fileId)
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
    }
}
