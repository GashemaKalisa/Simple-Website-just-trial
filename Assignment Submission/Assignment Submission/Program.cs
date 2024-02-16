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
          //Method that display second integer
            Console.WriteLine("The scond number: ");
            
            
            Console.WriteLine("The Product is: "+numbers.Calculation());
            Console.ReadLine();
            
            
        }
    }
}
