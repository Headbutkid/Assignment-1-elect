using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_elect
{
    public class Customerinfo
    {
        public static int customerinfo()  //defines a class which has methods inside
        {



            Console.WriteLine("Please enter the customers Unit: ");
            int unit = Convert.ToInt32(Console.ReadLine());

            return unit;

        }
    }
}
