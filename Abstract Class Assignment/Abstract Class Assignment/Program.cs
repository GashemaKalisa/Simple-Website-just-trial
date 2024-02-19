using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main method, instaiate an Employee object
            Employee sam = new Employee() { firstName = "Sample", lastName = "Student" };
            //Call the SayName method on the object
            sam.SayName();
            Console.ReadLine();
        }
    }
}
