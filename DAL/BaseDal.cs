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
        private const string connectionString = "user id=conn;password=conn;data source=XE";
        public BaseDal()
        {

        }

        protected OracleConnection CreateConnection()
        {
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();

            return conn;
        }
    }
}
