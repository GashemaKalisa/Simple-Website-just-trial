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
        public string firstName { get; set; }
        public string lastName { get; set; }
        //Give it the method SayName().
        public abstract void SayName();
    }
}


