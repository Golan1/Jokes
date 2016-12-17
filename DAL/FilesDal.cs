using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FilesDal : BaseDal
    {
        private const string SQL_GET_JOKES_IDS = @"
SELECT id
FROM joke
WHERE file_id=:FILE_ID
ORDER BY joke_index";

        public List<string> getJokesOfFile(decimal fileId)
        {
            var jokeDal = new JokeFormDal();

            var jokes = new List<string>();

            using (var conn = CreateConnection())
            {
                var cmd = new OracleCommand(SQL_GET_JOKES_IDS, conn);
                cmd.Parameters.Add("FILE_ID", fileId);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    jokes.Add(jokeDal.getJokeText(dr.GetDecimal(0)));
                }
            }

            return jokes;
        }

        public JokesDS.JK_FILEDataTable GetFiles()
        {
            JokesDSTableAdapters.JK_FILETableAdapter adapter = new JokesDSTableAdapters.JK_FILETableAdapter();

            return adapter.GetData();
            
        }
    }
}
