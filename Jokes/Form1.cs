using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    var x = new JokeFileInfo()
        //    {
        //        Title = "t",
        //        Author = "a",
        //        CreationDate = DateTime.Now,
        //        Rating = 7,
        //        Source = "s",
        //        Data = "hahahah"
        //    };

        //    System.Xml.Serialization.XmlSerializer s = new System.Xml.Serialization.XmlSerializer(typeof(JokeFileInfo));

        //    using (var sw = new StreamWriter(@".\\1.xml"))
        //    {
        //        s.Serialize(sw, x);
        //    }

        //}
    }
}
