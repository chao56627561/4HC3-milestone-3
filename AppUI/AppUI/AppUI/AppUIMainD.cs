using System;
using System.Windows.Forms;

namespace AppUI
{
    public partial class AppUIMainD : Form
    {
        private Form[] m_fMainForm;

        public AppUIMainD()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_fMainForm[2].Show();
        }

        private void AppUIMainD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
