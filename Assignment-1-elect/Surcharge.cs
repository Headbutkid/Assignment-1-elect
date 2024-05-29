using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_elect
{
    public class Surcharge
    {
        public static double surcharge(double charge)
        {

            double Surch = charge;


            if (Surch >= 400)
            {
                Surch = charge * 1.15;
            }
            else if (Surch <= 399)
            {
                Surch = charge * 0.0;
            }
            return Surch;
        }
    }
}
