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
        private string name;
        private List<string> msg;



        public List<string> friends;
        public List<string> workers;
        public List<string> family;


        public List<string> get_friends()
        {
            return friends;

        }


        public void iterate_friends()
        {

            for (int i = 0; i < friends.Count; i++)
            {
                Console.Out.WriteLine(friends[i]);

            }


        }

        public List<string> get_workers()
        {
            return workers;

        }


        public List<string> get_family()
        {
            return family;

        }

        
        
        
        
        public Contacts(string name)
        {

            this.name = name;
            msg = new List<string>();


        }


        public void add_message(string message)
        {
            
            msg.Add(message);
        }




        public List<string> get_messages()
        {
            return msg;







        } 

        public string get_name()
        {
         
            
            return this.name;
        }









    }
}
