using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class MathMethod2
    {
        //First method that takes an inters
        public int MathOp(int number)
        {
            return number + 7;
        }

        //Second method that takes a decimal
        public int MathOp(decimal number)
        {
            //convert the decimal to an int to perform math operation
            int newnum = Convert.ToInt32(number);
            return newnum * 20;
        }
        //Third MathOp that takes a string
        public int MathOp(string number)
        {
            //convert the string to an int to perform math operation
            int newnum = Convert.ToInt32(number);
            return newnum % 3;
        }
    }
}
