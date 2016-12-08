using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FilesDal : BaseDal
    {
        public JokesDS.JK_FILEDataTable GetFiles()
        {
            JokesDSTableAdapters.JK_FILETableAdapter adapter = new JokesDSTableAdapters.JK_FILETableAdapter();

            adapter.Fill(DS.JK_FILE);
            var data = DS.JK_FILE;
            return data;
        }
    }
}
