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
    public partial class AppUIMainB : Form
    {
        private Form[] m_fMainForm;

        public AppUIMainB()
        {
            InitializeComponent();

            List<string> user_contacts = new List<string>();



            Contacts user =  new Contacts();
            user.Addcontact("Joe", 1);
            user.Addcontact("Joe", 1);
            user.Addcontact("Joe", 1);
            user.Addcontact("Joe", 1);
            user.Getcontact(1);
            textBox1.Text = "Here";
         


            this.StartPosition = FormStartPosition.CenterScreen;
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_fMainForm[2].Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_fMainForm[3].Show();
        }

        private void AppUIMainB_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AppUIMainB_Load(object sender, EventArgs e)
        {

        }

        private void panelHead_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void PicPhoto_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
