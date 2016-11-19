using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DAL;

namespace Jokes
{
    public partial class LoadTab : UserControl
    {
        JokeFileInfo info;
        LoadTabDal myDal;

        public LoadTab()
        {
            InitializeComponent();

            info = new JokeFileInfo();
            info.CreationDate = DateTime.Now;          
            
            resetBindings();

            myDal = new LoadTabDal();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                info = XmlUtils.desirialize<JokeFileInfo>(fileName);

                txtFileName.Text = fileName;

                resetBindings();
            }
        }

        private void resetBindings()
        {
            txtTitle.DataBindings.Clear();
            txtTitle.DataBindings.Add("Text", info, "Title");
            txtAuthor.DataBindings.Clear();
            txtAuthor.DataBindings.Add("Text", info, "Author");
            dtCreationDate.DataBindings.Clear();
            dtCreationDate.DataBindings.Add("Value", info, "CreationDate");
            txtSource.DataBindings.Clear();
            txtSource.DataBindings.Add("Text", info, "Source");
            numRating.DataBindings.Clear();
            numRating.DataBindings.Add("Value", info, "Rating");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            myDal.SaveNewFile(info);
        }
    }
}
