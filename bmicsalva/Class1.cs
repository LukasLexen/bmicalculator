using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Calculations
{
    internal class Calc
    {
        public float height { get; set; }
        public float weight { get; set; }

        public float CalculateBmi() 
        {
            return weight/height/height*10000;
        }

    
    }
}
