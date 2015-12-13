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

        private List<string> user_contacts;

        private List<PictureBox> pictures= new List<PictureBox>(); 

        public AppUIMainB()
        {
            InitializeComponent();





            Contacts user = new Contacts();






            user.Addcontact("Joe", 1);
            user.Addcontact("Joe2", 1);
            user.Addcontact("Joe3", 1);
            user.Addcontact("Joe4", 1);
            user.Addcontact("Joe5", 1);
            user_contacts = user.get_contacts();


            int y = 20;
            int y_change = 100;


            for (int i = 0; i < user_contacts.Count; i++)
            {

                PictureBox p1 = new PictureBox();

                p1.SetBounds(40, y, 60, 60);
                p1.Image = Image.FromFile("male@2x.png");
                panel1.Controls.Add(p1);
                pictures.Add(p1);
                y += y_change;



            }
            


           













            
            
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

       
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

       


       



      
    }
}