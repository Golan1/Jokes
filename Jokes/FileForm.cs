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
        private FileFormDalcs myDal;
        public int FileId{ get; set; }
        public FileForm(int fileId)
        {

            InitializeComponent();
            myDal = new FileFormDalcs();
            FileId = fileId;
            richTextBox1.Text = myDal.getFileText(FileId);
            
        }
    }
}
