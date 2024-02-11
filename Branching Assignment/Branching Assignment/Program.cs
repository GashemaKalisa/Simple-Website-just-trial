using System;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //starting of program
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
           
            Console.WriteLine("Enter Package weight");
            decimal package_weight = Convert.ToDecimal(Console.ReadLine()); //requesting user to enter a weight
            if (package_weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
            }
            //starting of else if this will be executed if package waight is less than 50
            else if  (package_weight < 50)   
                {
                Console.WriteLine("enter Package Width");
                decimal package_width = Convert.ToDecimal(Console.ReadLine()); //requesting user to enter a width
                Console.WriteLine("enter package height");
                decimal package_height = Convert.ToDecimal (Console.ReadLine()); //requesting user to enter a height
                Console.WriteLine("enter package length");
               decimal package_length = Convert.ToDecimal(Console.ReadLine()); //requesting user to enter a length
               decimal dimensions = package_width * package_height * package_length;
                if (dimensions > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express.");
                }
                else if (dimensions < 50)
                {
                   decimal estimated_total = (dimensions * package_weight) / 100;

                    Console.WriteLine("Your estimated total for shipping this package is $"+estimated_total);
                }
            }





            Console.ReadLine();
        }
    }
}
