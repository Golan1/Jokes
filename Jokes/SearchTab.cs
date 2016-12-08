﻿using System;
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

        public SearchTab()
        {
            InitializeComponent();

            myDal = new SearchDal();

            refreshSearchHistory();
        }

        private void refreshSearchHistory()
        {
            var searchHistory = myDal.GetSearchHistory();

            var source = new AutoCompleteStringCollection();

            source.AddRange(searchHistory.ToArray());

            txtSearch.AutoCompleteCustomSource = source;
        }

        private void dgvFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        //    var drv= (DataRowView)dgvFiles.Rows[e.RowIndex].DataBoundItem;
        //    var myRow = (JokesDS.JK_FILERow)drv.Row;
        //    FileForm form = new FileForm(myRow.ID);
        //    form.ShowDialog();
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
        }
    }
}