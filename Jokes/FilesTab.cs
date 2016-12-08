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
        public FilesTab()
        {
            InitializeComponent();

            myDal = new FilesDal();

            dgvFiles.DataSource = myDal.GetFiles();
        }

        private void dgvFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var drv= (DataRowView)dgvFiles.Rows[e.RowIndex].DataBoundItem;
            var myRow = (JokesDS.JK_FILERow)drv.Row;
            FileForm form = new FileForm(myRow.ID);
            form.ShowDialog();
        }
    }
}
