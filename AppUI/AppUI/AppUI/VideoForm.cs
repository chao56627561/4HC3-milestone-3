using System;
using System.Windows.Forms;

namespace AppUI
{
    public partial class VideoForm : Form
    {
        private Form m_parentWnd;

        public VideoForm(Form parentWnd,string title)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;

            m_parentWnd = parentWnd;
            labelTitle.Text = title;
        }

        private void VideoForm_FormClosed(object sender, FormClosedEventArgs e)
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
