using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_elect
{
    public class Surcharge
    {
        public static double surcharge(int unit)
        {

            double surch = unit;


            if (surch >= 400)
            {
                surch = unit * 1.15;
            }
            else if (surch <= 399)
            {
                surch = unit * 0.45;
            }
            return surch;
        }
    }
}
