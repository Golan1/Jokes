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
    public partial class SearchTab : UserControl
    {
        SearchDal myDal;
        MainForm mainForm;

        public SearchTab()
        {
            InitializeComponent();

            myDal = new SearchDal();
        }

        private void refreshSearchHistory()
        {
            var searchHistory = myDal.GetSearchHistory();

            var source = new AutoCompleteStringCollection();

            source.AddRange(searchHistory.ToArray());

            txtSearch.AutoCompleteCustomSource = source;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var text = txtSearch.Text;

            if (string.IsNullOrWhiteSpace(text))
                return;

            var source = txtSearch.AutoCompleteCustomSource;
            if (!source.Contains(text))
            {
                source.Add(text);
                myDal.AddToSearchHistory(text);
            }

            dgvSearchResults.DataSource = myDal.GetSearchResults(text);
        }

        private void dgvSearchResults_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btnGo_Click(this, null);
            }
        }

        private void SearchTab_Load(object sender, EventArgs e)
        {
            refreshSearchHistory();

            mainForm = (MainForm)Parent.Parent.Parent;
        }
    }
}