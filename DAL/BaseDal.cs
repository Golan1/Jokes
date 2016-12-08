using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    abstract public class BaseDal
    {
        private const string SQL_SELECT_SEQ = "SELECT {0}.nextval from dual";

        public JokesDS DS { get; set; }


        public BaseDal()
        {
            DS = new JokesDS();
        }

        protected OracleConnection CreateConnection()
        {
            OracleConnection conn = new OracleConnection(Properties.Settings.Default.ConnectionString);
            conn.Open();

            return conn;
        }

        protected int NextVal(string seqName, OracleConnection conn)
        {
            var cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = string.Format(SQL_SELECT_SEQ, seqName);

            var returnValue = int.Parse(cmd.ExecuteScalar().ToString());

            return returnValue;
        }
    }
}