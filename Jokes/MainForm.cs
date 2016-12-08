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
    public partial class MainForm : Form
    {

        private Joke jokeForm;

        public MainForm()
        {
            InitializeComponent();

            jokeForm = new Joke();
        }

        public void RefreshFiles()
        {
            this.filesTab1.RefreshFiles();
        }

        public void showJokes(string word, int selected, JokesDS.SEARCH_RESULTDataTable res)
        {
            jokeForm.updateJokes(word, selected, res);
            jokeForm.Show();
        }
    }
}
