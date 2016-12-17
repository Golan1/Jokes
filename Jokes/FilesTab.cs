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
    public partial class FilesTab : UserControl
    {
        FilesDal myDal;
        MainForm mainForm;

        public FilesTab()
        {
            InitializeComponent();

            myDal = new FilesDal();
        }

        private void dgvFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var drv = (DataRowView)dgvFiles.Rows[e.RowIndex].DataBoundItem;
            var myRow = (JokesDS.JK_FILERow)drv.Row;

            mainForm.ShowFile(myRow.ID, myRow.TITLE);
        }

        public void RefreshFiles()
        {
            dgvFiles.DataSource = myDal.GetFiles();
        }

        private void FilesTab_Load(object sender, EventArgs e)
        {
            RefreshFiles();
            mainForm = (MainForm)Parent.Parent.Parent;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvFiles.SelectedRows)
            {
                var fileRow = (row.DataBoundItem as DataRowView).Row as JokesDS.JK_FILERow;

                var x = new JokeFileInfo()
                {
                    Title = fileRow.TITLE,
                    Author = fileRow.AUTHOR,
                    CreationDate = fileRow.CREATION_DATE,
                    Rating = fileRow.RATING,
                    Source = fileRow.SOURCE,
                    Jokes = myDal.getJokesOfFile(fileRow.ID)
                };

                System.Xml.Serialization.XmlSerializer s = 
                    new System.Xml.Serialization.XmlSerializer(typeof(JokeFileInfo));

                using (var sw = new StreamWriter(string.Format(@".\\{0}{1}.xml", x.Title, fileRow.ID)))
                {
                    s.Serialize(sw, x);
                }
            }
        }
    }
}
