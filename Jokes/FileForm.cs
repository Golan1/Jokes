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
        private FileFormDal myDal;

        private MainForm mainForm;
        public decimal FileId { get; set; }

        public FileForm(decimal fileId, string fileTitle)
        {
            InitializeComponent();
            myDal = new FileFormDal();
            txtTitle.Text = fileTitle;

            FileId = fileId;

            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Add to group");
            cm.MenuItems.Add("Add to relation (first)");
            cm.MenuItems.Add("Add to relation (seconed)");
            cm.MenuItems.Add("Search");

            richTextBox1.ContextMenu = cm;

            cm.MenuItems[0].Click += Joke_Click1;
            cm.MenuItems[1].Click += Joke_Click2;
            cm.MenuItems[2].Click += Joke_Click3;
            cm.MenuItems[2].Enabled = false;
            cm.MenuItems[3].Click += Joke_Click4;

        }

        private void Joke_Click1(object sender, EventArgs e)
        {

            mainForm.groupFire(richTextBox1.SelectedText);
            this.Close();
        }

        private void Joke_Click2(object sender, EventArgs e)
        {

            mainForm.firstRelWordFire(this.richTextBox1.SelectedText);
            richTextBox1.ContextMenu.MenuItems[1].Enabled = false;
            richTextBox1.ContextMenu.MenuItems[2].Enabled = true;

        }

        private void Joke_Click3(object sender, EventArgs e)
        {

            mainForm.secRelWordFire(this.richTextBox1.SelectedText);
            richTextBox1.ContextMenu.MenuItems[1].Enabled = true;
            richTextBox1.ContextMenu.MenuItems[2].Enabled = false;
            this.Close();
        }

        private void Joke_Click4(object sender, EventArgs e)
        {

            mainForm.searchFire(richTextBox1.SelectedText);
            this.Close();//send text to search
        }

        private void FileForm_Load(object sender, EventArgs e)
        {
            mainForm = (MainForm)this.Owner;
            richTextBox1.Text = myDal.GetFileText(FileId);

            SetAllWords();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetAllWords();
        }

        private void SetAllWords()
        {
            dgvWords.DataSource = myDal.GetWordsFile(FileId);
            numLine.Enabled = false;
            numLineIndex.Enabled = false;
            numJoke.Enabled = false;
            numJokeIndex.Enabled = false;

            rbJoke.Checked = false;
            rbLine.Checked = false;
        }

        private void SetByJoke()
        {
            numJoke.Enabled = true;
            numJokeIndex.Enabled = true;

            numLine.Enabled = false;
            numLineIndex.Enabled = false;

            dgvWords.DataSource =
                myDal.GetWordsFileByJokeAndIndex(FileId, numJoke.Value, numJokeIndex.Value);
            boldSelection();
        }

        private void SetByLine()
        {
            numLine.Enabled = true;
            numLineIndex.Enabled = true;

            numJoke.Enabled = false;
            numJokeIndex.Enabled = false;

            dgvWords.DataSource =
                    myDal.GetWordsFileByLineAndIndex(FileId, numLine.Value, numLineIndex.Value);
            boldSelection();

        }

        private void rbJoke_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJoke.Checked)
            {
                SetByJoke();
            }
            else
            {
                numJoke.Enabled = false;
                numJokeIndex.Enabled = false;
            }
        }

        private void rbLine_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLine.Checked)
            {
                SetByLine();
            }
            else
            {
                numLine.Enabled = false;
                numLineIndex.Enabled = false;
            }
        }

        private void numJoke_ValueChanged(object sender, EventArgs e)
        {
            SetByJoke();
        }

        private void numJokeIndex_ValueChanged(object sender, EventArgs e)
        {
            SetByJoke();
        }

        private void numLine_ValueChanged(object sender, EventArgs e)
        {
            SetByLine();
        }

        private void numLineIndex_ValueChanged(object sender, EventArgs e)
        {
            SetByLine();
        }

        private void boldSelection()
        {

            var res = dgvWords.DataSource as JokesDS.WORD_IN_JOKEDataTable;
            if (res.Count <= 0) return;
            //wordLable.Text = word;
            var JokeId = (res.Rows[0] as JokesDS.WORD_IN_JOKERow).JOKE_ID;
            decimal idx = (res.Rows[0] as JokesDS.WORD_IN_JOKERow).INDEX_IN_JOKE;
            decimal line = (res.Rows[0] as JokesDS.WORD_IN_JOKERow).LINE_INDEX;
            string word = (res.Rows[0] as JokesDS.WORD_IN_JOKERow).TEXT;
            var jkgIdx = (res.Rows[0] as JokesDS.WORD_IN_JOKERow).JOKE_INDEX;

            string joke = this.richTextBox1.Text;
            // var lines = joke.s

            var wordsList = joke.Split(' ', '\n');//.Where( (x)=>x.Length> 0 ).ToArray();
            int cnt = word.Split(' ').Length;
            int charIndex = 0;
            ////int lines = 0;
            int k = 0;
            int i = 0;
            int j = 0;
            while ((k < idx) || (j < jkgIdx))
            {
                if (j == jkgIdx)
                    k++;
                if (wordsList[i].Length > 0)
                    charIndex += wordsList[i].Length;
                else
                {
                    charIndex++;
                    j++;
                }
                i++;

            }

            if (charIndex > 0)
                charIndex += i - j;

            //// idx = (res.Rows[selected] as JokesDS.SEARCH_RESULTRow).FIRST_INDEX;

            var tmp = joke.Split(' ', '\n').ToList().GetRange(i, cnt);

            string tmp2 = "";
            foreach (var t in tmp)
                tmp2 += t;

            richTextBox1.Clear();
            richTextBox1.Text = joke;
            richTextBox1.Select(charIndex, tmp2.Length);
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
        }
    }
}
