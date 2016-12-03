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
        public int JokeId{ get; set; }
        public FileForm MyFileForm { get; set; }

        public Joke(string word, int id)
        {
            InitializeComponent();
            JokeId = id;
            wordLable.Text = word;
            string joke = myDal.getJokeText(JokeId);
            jokeTextBox.Text = joke;
        }

        private void fullFileBtn_Click(object sender, EventArgs e)
        {
             int fileId = myDal.getFileId(JokeId);
            MyFileForm = new FileForm(fileId);          

            MyFileForm.Show();

        }
    }
}
