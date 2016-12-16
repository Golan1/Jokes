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
    public partial class Joke : Form
    {
        private JokeFormDal myDal;

        public FileForm MyFileForm { get; set; }
        public decimal JokeId { get; set; }

        private MainForm mainForm;

        public Joke()
        {
            InitializeComponent();

            myDal = new JokeFormDal();

            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Add to group");
            cm.MenuItems.Add("Add to relation (first)");
            cm.MenuItems.Add("Add to relation (seconed)");
            cm.MenuItems.Add("Search");

            jokeTextBox.ContextMenu = cm;

            cm.MenuItems[0].Click += Joke_Click1;
            cm.MenuItems[1].Click += Joke_Click2;
            cm.MenuItems[2].Click += Joke_Click3;
            cm.MenuItems[2].Enabled = false;
            cm.MenuItems[3].Click += Joke_Click4;

        }

        private void Joke_Click1(object sender, EventArgs e)
        {
            mainForm.groupFire(jokeTextBox.SelectedText);
            this.Close();
        }

        private void Joke_Click2(object sender, EventArgs e)
        {
            mainForm.firstRelWordFire(this.jokeTextBox.SelectedText);
            jokeTextBox.ContextMenu.MenuItems[1].Enabled = false;
            jokeTextBox.ContextMenu.MenuItems[2].Enabled = true;

        }

        private void Joke_Click3(object sender, EventArgs e)
        {
            mainForm.secRelWordFire(this.jokeTextBox.SelectedText);
            jokeTextBox.ContextMenu.MenuItems[1].Enabled = true;
            jokeTextBox.ContextMenu.MenuItems[2].Enabled = false;
            this.Close();
        }

        private void Joke_Click4(object sender, EventArgs e)
        {

            mainForm.searchFire(jokeTextBox.SelectedText);
            this.Close();//send text to search
        }


        private int selected;
        private JokesDS.SEARCH_RESULTDataTable myJokes;

        private void UpdateJoke(JokesDS.SEARCH_RESULTRow joke)
        {
            lblSearchedText.Text = joke.SEARCH_TEXT;

            string jokeFullText = myDal.getJokeText(joke.JOKE_ID);

            int firstIndex = (int)joke.FIRST_INDEX;

            var wordsList = jokeFullText.Split(
                new string[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).
                ToList();


            int charFirstIndex = 0;
            for (int i = 0; i < firstIndex; i++)
            {
                if (wordsList[i].Length > 0)
                    charFirstIndex += wordsList[i].Length;
            }

            if (charFirstIndex > 0)
                charFirstIndex += firstIndex;

            var searchList = wordsList.GetRange(firstIndex, joke.SEARCH_TEXT.Split(' ').Length);

            int searchListLength = 0;
            foreach (var t in searchList)
                searchListLength += t.Length;

            // Add spaces length
            searchListLength += searchList.Count - 1;

            jokeTextBox.Clear();
            jokeTextBox.Text = jokeFullText;
            jokeTextBox.Select(charFirstIndex, searchListLength);
            jokeTextBox.SelectionFont = new Font(jokeTextBox.SelectionFont, FontStyle.Bold);
        }

        public void UpdateJokes(int firstSelected, JokesDS.SEARCH_RESULTDataTable results)
        {
            this.selected = firstSelected;
            myJokes = results;

            UpdateJoke(myJokes[selected]);
        }

        private void fullFileBtn_Click(object sender, EventArgs e)
        {
            //int fileId = myDal.getFileId(JokeId);
            //MyFileForm = new FileForm(fileId);          

            //MyFileForm.Show();'

            string title = (myJokes.Rows[selected] as JokesDS.SEARCH_RESULTRow).FILE_TITLE;
            decimal id = (myJokes.Rows[selected] as JokesDS.SEARCH_RESULTRow).FILE_ID;
            mainForm.ShowFile(id, title);

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (selected + 1 < myJokes.Rows.Count)
            {
                selected++;

                UpdateJoke(myJokes[selected]);
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (selected - 1 >= 0)
            {
                selected--;

                UpdateJoke(myJokes[selected]);
            }
        }

        private void Joke_Load(object sender, EventArgs e)
        {
            mainForm = (MainForm)this.Owner;
        }
    }
}
