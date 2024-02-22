using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //, instaiate an Employee object
            var compar = new Employee();

            //Assigning Values to the properties
            compar.Id = 001;
            compar.FirstName = "Gashema";
            compar.LastName = "Kalisa";

            var comparis = new Employee();
            comparis.Id = 002;
            comparis.FirstName = "Hazard";
            comparis.LastName = "Stanley";

            if (compar == comparis)
            {
                Console.WriteLine("Employee " + compar.LastName + " his Idd  equal to " + comparis.LastName);
            }
            compar.Id = 001;



            if (compar != comparis)
            {
                Console.WriteLine("Employee " + compar.LastName + " his Idd not equal to " + comparis.LastName);
            }
            compar.Id = 002;

            Console.ReadLine();
          
        }
        
    }
}
