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
    public partial class VoiceChat : Form
    {
        private Form m_parentWnd;
        public VoiceChat(Form parentWnd,string title)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;

            m_parentWnd = parentWnd;
            labelTitle.Text = title;
        }

        private void VoiceChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            m_parentWnd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            m_parentWnd.Show();
        }
    }
}
