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
        SELECT j.id, LISTAGG(wij.text , ' ') WITHIN GROUP (ORDER BY wij.index_in_joke) AS text
        FROM   joke j
        JOIN word_in_joke wij ON j.id = wij.joke_id
        WHERE j.file_id = :FILE_ID
        GROUP BY j.id
        order by j.joke_index;";

        public string getFileText (decimal fileId)
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
