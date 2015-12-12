using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUI
{
    class Contacts


    {

        public List<string> friends { get; private set; }
        public List<string> workers { get; private set; }
        public List<string> family { get; private set; }
        public Contacts()
        {
            friends = new List<string>();
            workers = new List<string>();
            family = new List<string>();

            TextBox a = new TextBox();
            a.SetBounds(60, 80, 100, 120);
            a.Show();
            a.Text = "Here";

        }




        public void Addcontact(string name, int type)
        {
            if (type == 1)
            friends.Add(name);
            else if (type==2)
            workers.Add(name);
            else
            family.Add(name);



        }


        public void Getcontact( int type)
        {
            if (type == 1)
                for (int i = 0; i < friends.Count; i++)
                {
                    Console.WriteLine("Hello");
                }
         

        }

         public List<string> get_contacts ()
         {
             List <string>contacts = new List<string>(); 
             for (int i = 0; i < friends.Count; i++)
             {
                 contacts.Add(friends.e);
             }
             for (int i = 0; i < family.Count; i++)
             {

             }
             for (int i = 0; i < workers.Count; i++)
             {

             }
             return null;

         }

    }
}
