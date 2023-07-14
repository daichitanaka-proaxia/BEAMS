using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEAMS
{ 
    public static class Extension
    {
        public static string Deliminate(this int value)
        {
            return String.Format("{0:#,0}", value);
        }
    }
}
