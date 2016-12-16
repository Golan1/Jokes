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
    public partial class RelationsTab : UserControl
    {
        private RelationsTabDal myDal;
        public Dictionary<int, string> Relations { get; set; }
        public RelationsTab()
        {
            InitializeComponent();
            myDal = new RelationsTabDal();

            relationsListBox.SelectedIndexChanged += RelationsListBox_SelectedIndexChanged;

        }


        public void updateFirstW(string w)
        {
            this.word1TextBox.Text = w;
        }

        public void updateSecW(string w)
        {
            this.word2TextBox.Text = w;
        }

        private void RelationsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = relationsListBox.SelectedIndex;

            if (idx == -1) return;

            int id = Relations.Keys.ToArray()[idx];
            var tuples = myDal.getTupplesInRelation(id);
            tuplesListBox.Items.Clear();
            foreach (var t in tuples)
                tuplesListBox.Items.Add(t.Item1 + " / " + t.Item2);
        }

        private void getRelations()
        {
            Relations = myDal.getRelations();
            List<string> relationsNames = Relations.Values.ToList();
            foreach (var g in relationsNames)
                relationsListBox.Items.Add(g);
        }


        private void addRelationBtn_Click(object sender, EventArgs e)
        {
            string newRalation = relationTextBox.Text;

            if (newRalation == string.Empty)
                MessageBox.Show("Please enter a reltaions name");
            else
            {
                bool success = true;
                try
                {
                    myDal.saveNewRelation(newRalation);
                }
                catch (Exception exp)
                {
                    success = false;
                    MessageBox.Show(exp.Message);
                }
                if (success)
                {
                    relationsListBox.Items.Clear();
                    getRelations();
                }
            }
        }

        private void AddTupleBtn_Click(object sender, EventArgs e)
        {
            string word1 = word1TextBox.Text;
            string word2 = word2TextBox.Text;
            string selectedRelations = (string)relationsListBox.SelectedItem;
            int idx = relationsListBox.SelectedIndex;

            if (idx == -1)
                MessageBox.Show("Please select relation");
            else
            {

                int id = Relations.Keys.ToArray()[idx];

                if ((word1 == string.Empty) || (word2 == string.Empty))
                    MessageBox.Show("Please enter both words");
                else
                {
                    bool success = true;
                    try
                    {
                        myDal.saveTuppleToRelation(word1, word2, id);
                    }
                    catch (Exception exp)
                    {
                        success = false;
                        MessageBox.Show("Something is worng");
                    }
                    if (success)
                        tuplesListBox.Items.Add(word1 + " / " + word2); ;
                }
            }
        }

        private void RelationsTab_Load(object sender, EventArgs e)
        {
            getRelations();
        }
    }
}
