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
    }
}
