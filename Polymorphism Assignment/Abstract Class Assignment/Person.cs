using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    //Create an abstract class "Person" with two string properties : FirstName and LastName
    public abstract class Person
    {
        public string Country { get; set; }
        public string city { get; set; }
        //Give it the method Quit().
        public  void Quit();
    }
}


