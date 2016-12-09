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
        public decimal FileId{ get; set; }

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
        }

        private void SetByLine()
        {
            numLine.Enabled = true;
            numLineIndex.Enabled = true;

            numJoke.Enabled = false;
            numJokeIndex.Enabled = false;

            dgvWords.DataSource =
                    myDal.GetWordsFileByLineAndIndex(FileId, numLine.Value, numLineIndex.Value);
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
    }
}
