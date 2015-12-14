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
    public partial class NewFriend : Form
    {
        AppUIMainC m_parentWnd;

        public NewFriend(AppUIMainC parentWnd)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;

            m_parentWnd = parentWnd;

            for(int i=0;i<m_parentWnd.m_Friends.Count;i++)
            {
                listBox1.Items.Add(m_parentWnd.m_Friends[i].name);
            }
            listBox1.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            m_parentWnd.Show();
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            if(name.Length != 0)
            {
                if(true == m_parentWnd.addNewFriend((string)listBox1.SelectedItem, name))
                {
                    this.Close();
                    m_parentWnd.Show();
                }
                else
                {
                    MessageBox.Show(this, "This friend was already exists!", "Warning");
                }
            }
            else
            {
                MessageBox.Show(this, "Please input something!", "Warning");
            }
        }

        private void NewFriend_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            m_parentWnd.Show();
        }
    }
}
