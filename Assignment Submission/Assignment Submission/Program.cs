using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate MathOperation1 class
            Mathoperation numbers = new Mathoperation();
            //Ask the user to provide first parameter
            Console.WriteLine("Enter a first number: ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            //Ask the user to provide Second parameter
            Console.WriteLine("Enter a second number: ");
            int Second_number = Convert.ToInt32(Console.ReadLine());
        
            int product = numbers.Calculation(first_number, Second_number);
            Console.WriteLine(product);
            
            
        }
    }
}
