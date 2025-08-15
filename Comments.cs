using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter
{


    internal class Comments
    {
        int Id;
        string cmText;

        public Comments(string text,int cmtId)
        {
            Id = cmtId;
            cmText = text;

        }

      public string getCmText()
        {
            return cmText; 
        }
        public void setCmText(string text) {
            cmText = text; }
        public int getId()
        {
            return Id;
        }
        override
            public string ToString()
        {
            return cmText;
        }

    }
}
