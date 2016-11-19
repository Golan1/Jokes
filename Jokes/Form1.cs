using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.IO;

namespace Jokes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string oradb = "user id=conn;password=conn;data source=XE";

            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();

            string sql = " select 1 as x from dual";
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            var x = dr["x"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = new JokeFileInfo()
            {
                Title = "t",
                Author = "a",
                CreationDate = DateTime.Now,
                Rating = 7,
                Source = "s",
                Data = "hahahah"
            };

            System.Xml.Serialization.XmlSerializer s = new System.Xml.Serialization.XmlSerializer(typeof(JokeFileInfo));

            using (var sw = new StreamWriter(@".\\1.xml"))
            {
                s.Serialize(sw, x);
            }

        }
    }
}
