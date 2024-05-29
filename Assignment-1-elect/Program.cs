namespace Assignment_1_elect
{
     class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("Customer Information");
            Console.WriteLine("Please enter the customers ID, (Integer only): ");
            int num = Convert.ToInt32(Console.ReadLine()); //This makes the console switch from string (Words) to Integers (Numbers)
            Console.WriteLine("Please enter the customers name: ");
            string? Name = Console.ReadLine();//This reads user input
            //
            int Unit = Customerinfo.customerinfo(); //defining class and a method inside the class.

            //Logic.calc();//Calculation 
            double Charge = Logic.calc(Unit);//returning a internal value which was made public.
            double Surch = Surcharge.surcharge(Charge);

            Console.WriteLine("-----Invoice----");




            Console.WriteLine("Your information is the following: Name " + Name + " User ID " + num + " Surcharge " + Surch);
            Console.ReadKey();
        }
    }
}
