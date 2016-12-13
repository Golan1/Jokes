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
        public void updateJokes (string word, int selected, JokesDS.SEARCH_RESULTDataTable res )
        {
            this.selected = selected;
            myJokes = res;
            wordLable.Text = word;
            JokeId = (res.Rows[selected] as JokesDS.SEARCH_RESULTRow).JOKE_ID;
            decimal idx = (res.Rows[selected] as JokesDS.SEARCH_RESULTRow).FIRST_INDEX;
            decimal line = (res.Rows[selected] as JokesDS.SEARCH_RESULTRow).LINE_INDEX;
           
            string joke = myDal.getJokeText(JokeId);
            // var lines = joke.s
            
            var wordsList = joke.Split(' ','\n');//.Where( (x)=>x.Length> 0 ).ToArray();
            int cnt = word.Split(' ').Length ;
            int charIndex = 0;
            //int lines = 0;
            for (int i = 0; i < idx; i++)
            {
                if(wordsList[i].Length>0)
                    charIndex += wordsList[i].Length;

            }

            if(charIndex>0)
            charIndex+= (int)idx;//= (int)line;

            // idx = (res.Rows[selected] as JokesDS.SEARCH_RESULTRow).FIRST_INDEX;



            var tmp = joke.Split(' ', '\n').ToList().GetRange((int)idx, cnt);

            string tmp2 = "";
            foreach (var t in tmp)
                tmp2 += t;

            jokeTextBox.Clear();
            jokeTextBox.Text = joke;
            jokeTextBox.Select(charIndex, tmp2.Length);
            jokeTextBox.SelectionFont = new Font(jokeTextBox.SelectionFont, FontStyle.Bold);


        }

        private void fullFileBtn_Click(object sender, EventArgs e)
        {
            //int fileId = myDal.getFileId(JokeId);
            //MyFileForm = new FileForm(fileId);          

            //MyFileForm.Show();'

            string title = (myJokes.Rows[selected] as JokesDS.SEARCH_RESULTRow).FILE_TITLE;
            decimal id =  (myJokes.Rows[selected] as JokesDS.SEARCH_RESULTRow).FILE_ID;
            mainForm.ShowFile(id , title);

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (selected + 1 < myJokes.Rows.Count)
            {
                selected++;
                updateJokes(wordLable.Text, selected, myJokes);

            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (selected - 1 >=0)
            {
                selected--;
                updateJokes(wordLable.Text, selected, myJokes);

            }
        }

        private MainForm mainForm;
        private void Joke_Load(object sender, EventArgs e)
        {
            mainForm = (MainForm)this.Owner;
        }
    }
}
