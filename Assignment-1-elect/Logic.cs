using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_elect
{
    public class Logic
    {
        public static double calc(int unit)
        {

            double charge = 0;

            if (unit <= 199)
            {
                charge = unit * 0.30;
            }
            else if (unit >= 200 && unit <= 400)
            {
                charge = unit * 0.32;
            }
            else if (unit >= 400 && unit <= 600)
            {
                charge = unit * 0.36;
            }
            else if (unit >= 600)
            {
                charge = unit * 0.42;
            }

            Console.WriteLine($"the charge is: {charge} ");
            return charge;
        }
    }
}
