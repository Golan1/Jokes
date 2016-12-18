using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace Jokes
{
    public partial class StatisticsTab : UserControl
    {

        private StatisticsTabDal myDal;

        public StatisticsTab()
        {
            InitializeComponent();
            myDal = new StatisticsTabDal();
        }

        private void maxWordsFile_CheckedChanged(object sender, EventArgs e)
        {
            var x = myDal.max_words_file();
            richTextBox1.Text = x.Item2;
            textBox1.Text = x.Item1;
        }

        private void minJokes_CheckedChanged(object sender, EventArgs e)
        {
            var x = myDal.min_words_file();
            richTextBox1.Text = x.Item2;
            textBox1.Text = x.Item1;
        }

        private void maxWords_CheckedChanged(object sender, EventArgs e)
        {
            var x = myDal.max_words_joke();
            richTextBox1.Text = x.Item2;
            textBox1.Text = x.Item1;
        }

        private void minWords_CheckedChanged(object sender, EventArgs e)
        {
            var x = myDal.min_words_joke();
            richTextBox1.Text = x.Item2;
            textBox1.Text = x.Item1;
        }

        private void minLetters_CheckedChanged(object sender, EventArgs e)
        {
            var x = myDal.shortestWord();
            richTextBox1.Text = x.Item2;
            textBox1.Text = x.Item1;
        }

        private void maxLetters_CheckedChanged(object sender, EventArgs e)
        {
            var x = myDal.longestWord();
            richTextBox1.Text = x.Item2;
            textBox1.Text = x.Item1;
        }

        private void avgJokes_CheckedChanged(object sender, EventArgs e)
        {
            var x = myDal.avg_words_file();
            richTextBox1.Text = "";
            textBox1.Text = x;
        }

        private void avgWords_CheckedChanged(object sender, EventArgs e)
        {
            var x = myDal.avg_words_joke();
            richTextBox1.Text = "";
            textBox1.Text = x;
        }

        private void avgLetters_CheckedChanged(object sender, EventArgs e)
        {
            var x = myDal.avg_word();
            richTextBox1.Text = "";
            textBox1.Text = x;
        }

        private void mostCommon_CheckedChanged(object sender, EventArgs e)
        {
            var x = myDal.mostComm();
            richTextBox1.Text = x.Item2;
            textBox1.Text = x.Item1;
        }


    }
}
