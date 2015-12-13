using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUI
{
    public partial class AppUIMainC : Form
    {
        int x = 30;
        int y = 100;

        int distance_x = 200;
        int distance_y2 = 120;
        int distance_y1 = 0;
        private void AddControls()
        {
            

            
        }

        
        private Form[] m_fMainForm;

        public AppUIMainC()
        {
            InitializeComponent();
             

            
           


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

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void panelHead_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            int y_change = 240;
            
           PictureBox txt = new PictureBox();
           txt.Image = Image.FromFile("male@2x.png");
           txt.SetBounds(x,y+ distance_y1,60,60);
            
           this.Controls.Add(txt);
          
            
            
            PictureBox txt2 = new PictureBox();

           txt2.Image = Image.FromFile("male@2x.png");
           txt2.SetBounds(x + distance_x, y+ distance_y2, 60, 60);
           this.Controls.Add(txt2);
            distance_y1 = distance_y1 + y_change;


           
            
        }


        private void message()
        {
            



        }

        private void vScrollBarTable_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void AppUIMainC_Load(object sender, EventArgs e)
        {

        }







    }
}
