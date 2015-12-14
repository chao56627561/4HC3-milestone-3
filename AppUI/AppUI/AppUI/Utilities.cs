
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppUI
{
    public class _tagChatContexts
    {
        public _tagChatContexts(int t,string n,string m)
        {
            tag = t;
            name = n;
            msg = m;
        }

        public int tag;
        public string name;
        public string msg;
    }

    public class _tagChatRecord
    {
        public int tag;
        public string name;
        public string picPath;
        public string lastMsg;
        public DateTime date;
        public List<_tagChatContexts> allContext;
        public Panel panel;
    }

    public class _tagGroup
    {
        public string name;
        public List<string> persons;
    }

    public class _tagCategory
    {
        public string name;
        public List<string> persons;
    }
}
