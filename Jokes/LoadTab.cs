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
    public partial class LoadTab : UserControl
    {
        JokeFileInfo info;
        LoadDal myDal;

        MainForm mainForm;

        public LoadTab()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                info = XmlUtils.desirialize<JokeFileInfo>(fileName);

                txtFileName.Text = fileName;

                ResetDataBindings();
            }
        }

        private void ResetDataBindings()
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
            try
            {
                myDal.SaveNewFile(info);
                info = new JokeFileInfo();

                txtFileName.Text = "";
                ResetDataBindings();

                mainForm.RefreshFiles();

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LoadTab_Load(object sender, EventArgs e)
        {
            info = new JokeFileInfo();
            info.CreationDate = DateTime.Now;

            ResetDataBindings();

            myDal = new LoadDal();

            mainForm = (MainForm)Parent.Parent.Parent;
        }
    }
}
