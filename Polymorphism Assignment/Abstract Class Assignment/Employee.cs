using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    //Interface inheritance for the class Employee
    public class Employee : Person,IQuittable
    {
        public int Id { get; set; }
      
        //Implement the Quit() method inside of the Employee class
        public override void Quit()
        {
            Console.WriteLine("He live in "+ Country+ " in the city of "+ city);
        }
           
        
    }
}
