using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUI
{
    public partial class NewGroupFrom : Form
    {
        AppUIMainC m_parentWnd;

        public NewGroupFrom(AppUIMainC parentWnd)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;

            m_parentWnd = parentWnd;

        }

        private void NewGroupFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            m_parentWnd.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            m_parentWnd.Show();
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            String group = textBox1.Text.Trim();

            if (group.Length != 0)
            {
                List<string> list = new List<string>();
                for(int i=0;i< listBox1.SelectedItems.Count;i++)
                {
                    list.Add((string)listBox1.SelectedItems[i]);
                }

                if (true == m_parentWnd.addNewGroup(group,list))
                {
                    this.Close();
                    m_parentWnd.Show();
                }
                else
                {
                    MessageBox.Show(this, "This group was already exists!", "Warning");
                }
            }
            else
            {
                MessageBox.Show(this, "Please input something!", "Warning");
            }
        }

        private void NewGroupFrom_Load(object sender, EventArgs e)
        {
            List<_tagCategory> list = m_parentWnd.m_Friends;

            for(int i=0;i<list.Count;i++)
            {
                for (int j = 0; j < list[i].persons.Count; j++)
                {
                    listBox1.Items.Add(list[i].persons[j]);
                }
            }
        }
    }
}
