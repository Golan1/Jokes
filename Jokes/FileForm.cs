using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace Jokes
{
    public partial class FileForm : Form
    {
        private FileFormDal myDal;
        public decimal FileId{ get; set; }
        public FileForm(decimal fileId)
        {

            InitializeComponent();
            myDal = new FileFormDal();
            FileId = fileId;
            richTextBox1.Text = myDal.getFileText(FileId);
            
        }
    }
}
