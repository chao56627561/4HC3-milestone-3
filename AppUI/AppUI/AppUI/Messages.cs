using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUI
{
    class Messages
    {

        private List<string> msg;

        public Messages()
        {

            msg= new List<string>();


        }


        public void addmsg(string add )
        
        {
            
            this.msg.Add(add);

        }


        public List<string> msgs()
        {



            return this.msg;











        } 


    }
}
