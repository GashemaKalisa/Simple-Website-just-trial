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
            Employee comparison = new Employee() { Id = 001, FirstName = "Gashema", LastName="Kalisa" };
            Employee comparison_s = new Employee() { Id2 = 002, FirstName = "Hazard", LastName = "stanley" };

            if (Id == Id2)
            {
                Console.WriteLine("id are equal");
            }
            else
            {
                Console.WriteLine("Id are not equal");
            }
            Console.ReadLine();
          
        }
        
    }
}
