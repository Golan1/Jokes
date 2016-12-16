using System;
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

                convertFile(fileName);

                txtFileName.Text = fileName;

                ResetDataBindings();
            }
        }

        private void convertFile(string fileName)
        {
            bool isXml;
            try
            {
                info = XmlUtils.desirialize<JokeFileInfo>(fileName);
                isXml = true;
            }
            catch (Exception)
            {
                isXml = false;
            }

            if (!isXml)
            {
                //info = new JokeFileInfo();
                info.Jokes = ConvertFreeFile(fileName);
            }
        }

        private List<string> ConvertFreeFile(string fileName)
        {
            string text;
            using (
                var sr = new StreamReader(fileName))
            {
                text = sr.ReadToEnd();
            }

            if (text[0] == '1' && text[1] == '.')
            {
                int index = 1;
                var jokes = new List<string>();

                int startJoke = text.IndexOf(index + ".") + 2;
                int endJoke = text.IndexOf((++index) + ".");

                string joke;

                while (endJoke != -1)
                {
                    joke = text.Substring(startJoke, endJoke - startJoke);
                    jokes.Add(joke);

                    startJoke = endJoke + index.ToString().Length + 1;

                    endJoke = text.IndexOf((++index) + ".");
                }

                joke = text.Substring(startJoke);

                jokes.Add(joke);

                return jokes;
            }
            else
            {
                return text.Split(new string[] { Environment.NewLine + Environment.NewLine, "\n\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
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
                if (string.IsNullOrWhiteSpace(txtFileName.Text))
                    return;

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

        private void button1_Click(object sender, EventArgs e)
        {
            info.Author = "Debug";
            info.CreationDate = DateTime.Now;
            info.Rating = 1;

            for (int j = 0; j < 1000; j++)
            {
                for (int i = 1; i < 5; i++)
                {
                    convertFile(string.Format(@"C:\Users\Golan\Documents\GitHub\Jokes\{0}.txt", i));
                    
                    info.Title = i + ".txt";

                    myDal.SaveNewFile(info);
                }
            }
        }
    }
}
