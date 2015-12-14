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
    public partial class NewCategory : Form
    {
        AppUIMainC m_parentWnd;

        public NewCategory(AppUIMainC parentWnd)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;

            m_parentWnd = parentWnd;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            m_parentWnd.Show();
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            String category = textBox1.Text.Trim();
            if(category.Length!=0)
            {
                if (true == m_parentWnd.addNewCategory(category))
                {
                    this.Close();
                    m_parentWnd.Show();
                }
                else
                {
                    MessageBox.Show(this, "This Catetory was already exists!", "Warning");
                }
            }
            else
            {
                MessageBox.Show(this, "Please input something!", "Warning");
            }
        }

        private void NewCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            m_parentWnd.Show();
        }
    }
}
