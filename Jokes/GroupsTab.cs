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
    public partial class GroupsTab : UserControl
    {

        private GroupsTabDal myDal;
        public Dictionary<int,string> Groups { get; set; }

        public GroupsTab()
        {
            InitializeComponent();

            groupsListBox.SelectedIndexChanged += GroupsListBox_SelectedIndexChanged;
            myDal = new GroupsTabDal();
            getGroups();
           

        }

        private void getGroups ()
        {
            Groups = myDal.getGroups();
            List<string> groupsNames = Groups.Values.ToList();
            foreach (var g in groupsNames)
                groupsListBox.Items.Add(g);
        }

        private void GroupsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = groupsListBox.SelectedIndex;
            int id = Groups.Keys.ToArray()[idx];
            var words =myDal.getWordsInGroup(id);
            wordsListBox.Items.Clear();
            foreach (var w in words)
                wordsListBox.Items.Add(w);
        }

        private void addGroupBtn_Click(object sender, EventArgs e)
        {
            string newGroup = groupTextBox.Text;

            if (newGroup == string.Empty)
                MessageBox.Show("Please enter a group name");
            else
            {
                bool success = true;
                try
                {
                    myDal.SaveNewGroup(newGroup);
                }
                catch (Exception exp)
                {
                    success = false;
                    MessageBox.Show(exp.Message);
                }
                if (success)
                {
                    groupsListBox.Items.Clear();
                    getGroups();
                }
            }

        }

        private void addWordBtn_Click(object sender, EventArgs e)
        {
            string newWord = wordTextBox.Text;
            string selectedGroup = (string)groupsListBox.SelectedItem;
            int idx = groupsListBox.SelectedIndex;

            if (idx == -1)
                MessageBox.Show("Please select group");
            else
            {
                int id = Groups.Keys.ToArray()[idx];

                if (newWord == string.Empty)
                    MessageBox.Show("Please enter a word");
                else
                {
                    bool success = true;
                    try
                    {
                        myDal.SaveWordToGroup(id, newWord);
                    }
                    catch (Exception exp)
                    {
                        success = false;
                        MessageBox.Show("Something is worng");
                    }
                    if (success)
                        wordsListBox.Items.Add(newWord);
                }
            }

        }
    }
}
