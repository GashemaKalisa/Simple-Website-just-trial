﻿using System;
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
            IQuittable Social = new Employee() { Country = "Canada", city = "Ottawa" };
            //Call the Quit method on the object
            Social.Quit();
            Console.ReadLine();
        }
    }
}
