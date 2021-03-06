﻿using System;
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
    public partial class MainForm : Form
    {

        private Joke jokeForm;

        public MainForm()
        {
            InitializeComponent();

          
        }

        public void RefreshFiles()
        {
            this.filesTab1.RefreshFiles();
        }

        public void groupFire (string selceted)
        {
            this.tabControl1.SelectedTab = this.tabControl1.TabPages[2];
            this.groupTab1.updateWord(selceted);
        }

        public void searchFire (string selected)
        {
            this.tabControl1.SelectedTab = this.tabControl1.TabPages[1];
            this.searchTab1.updateSearc(selected);
        }

        public void firstRelWordFire (string word)
        {
            this.relationTab1.updateFirstW(word);
        }

        public void secRelWordFire(string word)
        {
            this.tabControl1.SelectedTab = this.tabControl1.TabPages[3];
            this.relationTab1.updateSecW(word);
        }


        public void showJokes(int selected, JokesDS.SEARCH_RESULTDataTable res)
        {
            jokeForm = new Joke();
            jokeForm.UpdateJokes(selected, res);

            jokeForm.ShowDialog(this);
        }

        public void ShowFile(decimal fileId, string fileTitle)
        {
            var fileForm = new FileForm(fileId, fileTitle);
            fileForm.ShowDialog(this);
        }
    }
}
