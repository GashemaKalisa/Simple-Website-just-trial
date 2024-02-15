using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the MathMethod2 class
            MathMethod2 math1 = new MathMethod2();
            //call the first method with an int parameter
            Console.WriteLine(math1.MathOp(7));
            //call the second method with a decimal parameter
            Console.WriteLine(math1.MathOp(7.3m));
            //call the third method with a string parameter
            Console.WriteLine(math1.MathOp("7"));
        }
    }
}
