using Oracle.ManagedDataAccess.Client;
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
        private const string SQL_INSERT_JK_FILE = @"
INSERT INTO JK_FILE 
(id, title, author, rating, source, creation_date, insertion_date)
VALUES(
jk_file_seq.nextval, :TITLE, :AUTHOR, :RATING, :SOURCE, :CREATION_DATE, sysdate)";

        public void SaveNewFile(JokeFileInfo info)
        {
            using (var conn = CreateConnection())
            { 
                OracleCommand cmd = new OracleCommand(SQL_INSERT_JK_FILE, conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("TITLE", info.Title);
                cmd.Parameters.Add("AUTHOR", info.Author);
                cmd.Parameters.Add("RATING", info.Rating);
                cmd.Parameters.Add("SOURCE", info.Source);
                cmd.Parameters.Add("CREATION_DATE", info.CreationDate);

                var returnVal = cmd.ExecuteNonQuery();

                if (returnVal != 1)
                {
                    throw new Exception("Failed to insert data");
                }
            }
        }
    }
}
