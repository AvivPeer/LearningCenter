using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCenter
{
    internal class LcManager
    {
        public static int convertClassToInt(string strClass)
        {
            switch (strClass)
            {
                case "ט":
                    return 9;
                case "י":
                    return 10;
                case "יא":
                    return 11;
                case "יב":
                    return 12;

            }
            return -1;
        }
    }
}
