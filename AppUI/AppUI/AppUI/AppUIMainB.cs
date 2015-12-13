using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUI
{


    public partial class AppUIMainB : Form
    {




        int contact_picture_x = 30;
        int contact_picture_y = 20;




        int picture_y_change = 140;


        int user_picture_x = 250;
        int user_picture_y = 120;






        private Form[] m_fMainForm;

        private List<Contacts> user_contacts= new List<Contacts>();
        private List<Messages> msg = new List<Messages>();
        private List<PictureBox> pictures= new List<PictureBox>(); 
        private List<Button> b1 = new List<Button>();
        static  Contacts current = null;

       

        static  int current_chat = 0;
        
        
        public AppUIMainB()
        {
            InitializeComponent();

           


            textBox1.Hide();
            panelHead.Hide();


            Contacts user = new Contacts("joe");
            Contacts user1 = new Contacts("joe1");
            Contacts user2= new Contacts("joe2");
            Contacts user3 = new Contacts("joe3");
            Contacts user4 = new Contacts("joe4");


           
            user_contacts.Add(user);
            user_contacts.Add(user1);
            user_contacts.Add(user2);
            user_contacts.Add(user3);
            user_contacts.Add(user4); 






            int y = 20;
            int y_change = 100;
            int textbox_y = 30;

           
            
            
            
            
            for (int i = 0; i < user_contacts.Count; i++)
            {

                PictureBox p1 = new PictureBox();

                p1.SetBounds(40, y, 60, 60);
                p1.Image = Image.FromFile("male@2x.png");
                panel1.Controls.Add(p1);
                pictures.Add(p1);
                y += y_change;
                
                
                
                Button t1 = new Button();
                t1.SetBounds(100,textbox_y,200,20);

                t1.Text = user_contacts[i].get_name();
               
                
                panel1.Controls.Add(t1);


                b1.Add(t1);

                
                
                
                t1.Click += (IChannelSender, args) =>
                {
                    Console.Out.WriteLine(t1.Text);
                   
                    String chat = t1.Text;

                    for (int j = 0; j < user_contacts.Count; j++)
                    {
                        if (t1.Text == user_contacts[j].get_name())
                        {
                            Console.Out.WriteLine("the match" + user_contacts[j].get_name());
                            current = user_contacts[j];
                            if (current.get_messages().Count != 0)
                            {
                                Console.Out.WriteLine("We have messages");
                            }
                        }
                    }
               //     Console.WriteLine(chat);
                    



                   




                   
                 











                    panel1.Hide();
                    pictureBox11.Hide();
                    panel2.Show();
                   

                    
                    Send.Show();
                    textBox4.Show();
                    textBox1.Show();
                    panelHead.Show();


                };
                
                
                
                
                Console.Out.WriteLine(t1.Text);   
               


                TextBox t2 = new TextBox();
                
                t2.SetBounds(100, textbox_y+20, 200, 20);
                
                t2.Text = "last message....";
                
                panel1.Controls.Add(t2);
               
                
                textbox_y = textbox_y + y_change;

            }

            
            















            this.StartPosition = FormStartPosition.CenterScreen;
        }


        public void messagiing_contacts()
        {
            


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

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void PicPhoto_Click(object sender, EventArgs e)
        {

        }

       
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {





           

            

            PictureBox txt = new PictureBox();
            txt.Image = Image.FromFile("male@2x.png");
            txt.SetBounds(contact_picture_x, contact_picture_y, 60, 60);
            panel2.Controls.Add(txt);
            



            TextBox t1 = new TextBox();
            t1.Text = textBox4.Text;

            t1.SetBounds(contact_picture_x+80, contact_picture_y+20, 80, 60);
            current.add_message(t1.Text);
            panel2.Controls.Add(t1);
            textBox4.Clear();


            contact_picture_y += picture_y_change;
            
            
            
            PictureBox txt2 = new PictureBox();

            txt2.Image = Image.FromFile("male@2x.png");
            txt2.SetBounds(user_picture_x, user_picture_y, 60, 60);
            panel2.Controls.Add(txt2);

           



            


            TextBox t2 = new TextBox();
            t2.Text = "Hello";
            t2.SetBounds(user_picture_x - 90, user_picture_y, 80, 60);
            panel2.Controls.Add(t2);

            
            user_picture_y += picture_y_change;

            current.add_message(t1.Text);


            
           
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
             
        }

        private void panelHead_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelHead.Hide();
            textBox1.Hide();
            panel1.Show();
            panel2.Hide();
            panel2.Controls.Clear();
            pictureBox11.Show();
            textBox4.Hide();
            Send.Hide();



            contact_picture_x = 30;
            contact_picture_y = 20;




            picture_y_change = 140;


            user_picture_x = 250;
            user_picture_y = 120;




        }

       


       



      
    }
}