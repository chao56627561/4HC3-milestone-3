using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppUI
{
    public partial class AppUIMainC : Form
    {
        private Form[] m_fMainForm;
        private bool m_bFriend = true;

        public AppUIMainC()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;

            initializeFriend();
            initializeGroup();
        }

        public void setMainForm(Form[] forms)
        {
            m_fMainForm = forms;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_fMainForm[0].Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_fMainForm[1].Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_fMainForm[3].Show();
        }

        private void AppUIMainC_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (m_TreeFriends.Visible == false)
            {
                labelTitle.Text = "Friends List";
                m_bFriend = true;
                m_TreeGroups.Visible = false;
                m_TreeFriends.Visible = true;
                button1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (m_TreeGroups.Visible == false)
            {
                labelTitle.Text = "Groups List";
                m_bFriend = false;
                m_TreeFriends.Visible = false;
                m_TreeGroups.Visible = true;
                button1.Visible = false;
            }
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewCategory form = new NewCategory(this);
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(m_bFriend==true)
            {
                this.Hide();
                NewFriend form = new NewFriend(this);
                form.ShowDialog();
            }
            else
            {
                NewGroupFrom form = new NewGroupFrom(this);
                this.Hide();
                form.ShowDialog();
            }
        }

        private void treeViewFriend_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Action == TreeViewAction.ByMouse)
            {
                if(e.Node.Parent != null && e.Node.Nodes.Count==0)
                {
                    AppUIMainB formB = (AppUIMainB)m_fMainForm[1];
                    string strName = e.Node.Text;
                    this.Hide();

                    formB.newChatFormFriend(strName);
                }
            }
        }

        private void treeViewGroup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {
                if (e.Node.Parent != null && e.Node.Nodes.Count == 0)
                {
                    AppUIMainB formB = (AppUIMainB)m_fMainForm[1];
                    string strName = e.Node.Text;
                    this.Hide();

                    formB.newChatFormFriend(strName);
                }
                else
                {
                    AppUIMainB formB = (AppUIMainB)m_fMainForm[1];
                    string strName = e.Node.Text;
                    this.Hide();

                    formB.newChatFormGroup(strName);
                }
            }
        }

        public bool addNewCategory(string strCategory)
        {
            for(int i=0;i<m_Friends.Count;i++)
            {
                if (strCategory.Equals(m_Friends[i].name,
                    StringComparison.InvariantCultureIgnoreCase) == true)
                    return false;
            }

            TreeNode node = new TreeNode();
            node.Text = strCategory;
            m_TreeFriends.Nodes.Add(node);

            _tagCategory tmp = new _tagCategory();
            tmp.name = strCategory;
            tmp.persons = new List<string>();
            m_Friends.Add(tmp);

            return true;
        }

        public bool addNewFriend(string strCategory,string name)
        {
            int idx = -1;
            for(int i=0;i<m_Friends.Count;i++)
            {
                List<string> persons = m_Friends[i].persons;
                for(int j=0;j<persons.Count;j++)
                {
                    if (name.Equals(persons[j],
                            StringComparison.InvariantCultureIgnoreCase) == true)
                        return false;
                }

                if(strCategory.Equals(m_Friends[i].name,
                            StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    idx = i;
                }
            }

            if (idx == -1)
                return false;

            addNodeToTree(m_TreeFriends.Nodes[idx], m_Friends[idx].persons, name);

            return true;
        }

        public bool addNewGroup(string strGroupName,List<string> members)
        {
            for(int i=0;i<m_Groups.Count;i++)
            {
                string groupName = m_Groups[i].name;
                if (groupName.Equals(strGroupName,
                        StringComparison.InvariantCultureIgnoreCase) == true)
                    return false;
            }

            _tagGroup record;
            List<string> persons;
            TreeNode nodeGroup = new TreeNode();
            nodeGroup.Text = strGroupName;
            m_TreeGroups.Nodes.Add(nodeGroup);
            record = new _tagGroup();
            record.name = strGroupName;
            persons = new List<string>();
            for(int i=0;i<members.Count;i++)
            {
                addNodeToTree(nodeGroup, persons, members[i]);
            }
            record.persons = persons;
            m_Groups.Add(record);

            return true;
        }

        private void addNodeToTree(TreeNode parent,List<string> persons, string name)
        {
            TreeNode node = new TreeNode();
            node.Text = name;
            node.NodeFont = new Font("Arial", 12, FontStyle.Regular);
            parent.Nodes.Add(node);
            persons.Add(name);
        }

        private void initializeFriend()
        {
            m_TreeFriends = new TreeView();
            m_TreeFriends.Width = panelMain.Width;
            m_TreeFriends.Height = panelMain.Height;
            m_TreeFriends.Location = new Point(0, 0);
            m_TreeFriends.Scrollable = true;
            m_TreeFriends.LabelEdit = false;
            m_TreeFriends.ShowRootLines = true;
            m_TreeFriends.ShowPlusMinus = true;
            m_TreeFriends.ShowLines = false;
            m_TreeFriends.Font = new Font("Arial", 14, FontStyle.Bold);
            m_TreeFriends.AfterSelect += new TreeViewEventHandler(this.treeViewFriend_AfterSelect);
            m_Friends = new List<_tagCategory>();

            _tagCategory record;
            TreeNode nodeFriend = new TreeNode();
            nodeFriend.Text = "Friends";
            m_TreeFriends.Nodes.Add(nodeFriend);
            record = new _tagCategory();
            record.name = nodeFriend.Text;
            record.persons = new List<string>();
            addNodeToTree(nodeFriend, record.persons, "Bernard Tan");
            addNodeToTree(nodeFriend, record.persons, "Anna Sidorova");
            addNodeToTree(nodeFriend, record.persons, "Detmar Straub");
            addNodeToTree(nodeFriend, record.persons, "Cheri Speier");
            addNodeToTree(nodeFriend, record.persons, "James Spohrer");
            addNodeToTree(nodeFriend, record.persons, "Lorraine Staehr");
            addNodeToTree(nodeFriend, record.persons, "Thelma Truex");
            addNodeToTree(nodeFriend, record.persons, "Paul Pavlou");
            m_Friends.Add(record);

            TreeNode nodeFamily = new TreeNode();
            nodeFamily.Text = "Family";
            m_TreeFriends.Nodes.Add(nodeFamily);
            record = new _tagCategory();
            record.name = nodeFamily.Text;
            record.persons = new List<string>();
            addNodeToTree(nodeFamily, record.persons, "Kirsten Pavlou");
            addNodeToTree(nodeFamily, record.persons, "Christopher Smith");
            addNodeToTree(nodeFamily, record.persons, "Margaret Smith");
            addNodeToTree(nodeFamily, record.persons, "Lisa Zhu");
            addNodeToTree(nodeFamily, record.persons, "Lauren Eder");
            addNodeToTree(nodeFamily, record.persons, "Nathan Muskie");
            addNodeToTree(nodeFamily, record.persons, "Katherine Stewart");
            m_Friends.Add(record);

            TreeNode nodeClassmates = new TreeNode();
            nodeClassmates.Text = "Classmates";
            m_TreeFriends.Nodes.Add(nodeClassmates);
            record = new _tagCategory();
            record.name = nodeClassmates.Text;
            record.persons = new List<string>();
            addNodeToTree(nodeClassmates, record.persons, "Charles Wieland");
            addNodeToTree(nodeClassmates, record.persons, "Elizabeth Wieland");
            addNodeToTree(nodeClassmates, record.persons, "Eric van Heck");
            addNodeToTree(nodeClassmates, record.persons, "Barbara Cole");
            addNodeToTree(nodeClassmates, record.persons, "Mary Kate");
            addNodeToTree(nodeClassmates, record.persons, "Nicholas Teo");
            addNodeToTree(nodeClassmates, record.persons, "Patrice Skelkum");
            m_Friends.Add(record);

            TreeNode nodeTeam = new TreeNode();
            nodeTeam.Text = "Team";
            m_TreeFriends.Nodes.Add(nodeTeam);
            record = new _tagCategory();
            record.name = nodeTeam.Text;
            record.persons = new List<string>();
            addNodeToTree(nodeTeam, record.persons, "Michael Skelkum");
            addNodeToTree(nodeTeam, record.persons, "Jennie Triechler");
            addNodeToTree(nodeTeam, record.persons, "Richard Triechler");
            addNodeToTree(nodeTeam, record.persons, "Dana Jones");
            addNodeToTree(nodeTeam, record.persons, "Daniel Galletta");
            addNodeToTree(nodeTeam, record.persons, "Roxanne Galletta");
            addNodeToTree(nodeTeam, record.persons, "Dorothy Leidner");
            addNodeToTree(nodeTeam, record.persons, "Collette Rolland");
            m_Friends.Add(record);

            panelMain.Controls.Add(m_TreeFriends);
        }

        private void initializeGroup()
        {
            m_TreeGroups = new TreeView();
            m_TreeGroups.Width = panelMain.Width;
            m_TreeGroups.Height = panelMain.Height;
            m_TreeGroups.Location = new Point(0, 0);
            m_TreeGroups.Scrollable = true;
            m_TreeGroups.LabelEdit = false;
            m_TreeGroups.ShowRootLines = true;
            m_TreeGroups.ShowPlusMinus = true;
            m_TreeGroups.ShowLines = false;
            m_TreeGroups.Font = new Font("Arial", 14, FontStyle.Bold);
            m_TreeGroups.AfterSelect += new TreeViewEventHandler(this.treeViewGroup_AfterSelect);
            m_Groups = new List<_tagGroup>();

            _tagGroup record;
            List<string> persons;
            TreeNode nodeParty = new TreeNode();
            nodeParty.Text = "Sunday's Party";
            m_TreeGroups.Nodes.Add(nodeParty);
            record = new _tagGroup();
            record.name = nodeParty.Text;
            persons = new List<string>();
            addNodeToTree(nodeParty, persons, "Lauren Eder");
            addNodeToTree(nodeParty, persons, "Anna Sidorova");
            addNodeToTree(nodeParty, persons, "Detmar Straub");
            addNodeToTree(nodeParty, persons, "Mary Kate");
            addNodeToTree(nodeParty, persons, "Collette Rolland");
            addNodeToTree(nodeParty, persons, "Lorraine Staehr");
            addNodeToTree(nodeParty, persons, "Thelma Truex");
            addNodeToTree(nodeParty, persons, "Charles Wieland");
            record.persons = persons;
            m_Groups.Add(record);

            TreeNode nodeFilm = new TreeNode();
            nodeFilm.Text = "Film maker";
            m_TreeGroups.Nodes.Add(nodeFilm);
            record = new _tagGroup();
            record.name = nodeFilm.Text;
            persons = new List<string>();
            addNodeToTree(nodeFilm, persons, "Christopher Smith");
            addNodeToTree(nodeFilm, persons, "Margaret Smith");
            addNodeToTree(nodeFilm, persons, "Lisa Zhu");
            addNodeToTree(nodeFilm, persons, "Nathan Muskie");
            addNodeToTree(nodeFilm, persons, "Katherine Stewart");
            addNodeToTree(nodeFilm, persons, "Mary Kate");
            addNodeToTree(nodeFilm, persons, "Charles Wieland");
            record.persons = persons;
            m_Groups.Add(record);

            TreeNode nodeGame = new TreeNode();
            nodeGame.Text = "Warcraft team";
            m_TreeGroups.Nodes.Add(nodeGame);
            record = new _tagGroup();
            record.name = nodeGame.Text;
            persons = new List<string>();
            addNodeToTree(nodeGame, persons, "Elizabeth Wieland");
            addNodeToTree(nodeGame, persons, "Eric van Heck");
            addNodeToTree(nodeGame, persons, "Barbara Cole");
            addNodeToTree(nodeGame, persons, "Nicholas Teo");
            addNodeToTree(nodeGame, persons, "Patrice Skelkum");
            addNodeToTree(nodeGame, persons, "Mary Kate");
            addNodeToTree(nodeGame, persons, "Jennie Triechler");
            record.persons = persons;
            m_Groups.Add(record);

            TreeNode nodeVoodoo = new TreeNode();
            nodeVoodoo.Text = "Voodoo";
            m_TreeGroups.Nodes.Add(nodeVoodoo);
            record = new _tagGroup();
            record.name = nodeVoodoo.Text;
            persons = new List<string>();
            addNodeToTree(nodeVoodoo, persons, "Michael Skelkum");
            addNodeToTree(nodeVoodoo, persons, "Jennie Triechler");
            addNodeToTree(nodeVoodoo, persons, "Richard Triechler");
            addNodeToTree(nodeVoodoo, persons, "Dana Jones");
            addNodeToTree(nodeVoodoo, persons, "Daniel Galletta");
            addNodeToTree(nodeVoodoo, persons, "Roxanne Galletta");
            addNodeToTree(nodeVoodoo, persons, "Dorothy Leidner");
            addNodeToTree(nodeVoodoo, persons, "Elizabeth Wieland");
            record.persons = persons;
            m_Groups.Add(record);

            panelMain.Controls.Add(m_TreeGroups);
            m_TreeGroups.Visible = false;
        }

        public List<_tagCategory> m_Friends;
        public List<_tagGroup> m_Groups;
        public TreeView m_TreeFriends;
        public TreeView m_TreeGroups;
    }
}
