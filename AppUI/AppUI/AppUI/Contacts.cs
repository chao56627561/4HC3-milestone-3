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
        
        
        
        public List<string> friends { get; private set; }
        public List<string> workers { get; private set; }
        public List<string> family { get; private set; }
       
        
        
        
        
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
