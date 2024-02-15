﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate MathOperation1 class
            MathOperation1 mathOp = new MathOperation1();
            //Ask the user to provide first parameter
            Console.WriteLine("Enter an integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            //Ask the user to provide a second parameter or press enter
            Console.WriteLine("Enter  asecond interger, or just press enter: ");
            try
            {
                //Call method with 2 parameters if both parameters are provided
                int num2 = Convert.ToInt32(Console.ReadLine());
                int results = mathOp.MathOperation(num1, num2);
                Console.WriteLine(num1 + "X " + num2 + "=" + results);
            }
            catch
            {
                //Call method with one parameter if only one is provided
                int results = mathOp.MathOperation(num1);
                Console.WriteLine(num1 + "X default 1 = " + results);
            }
            Console.ReadLine();

        }
    }
}
