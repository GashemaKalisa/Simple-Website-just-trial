using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Submission
{
    class Mathoperation
    {
        //crate a method that takes two intergers as parameters
        //Make on parameter optional by providing a default value
        public int Calculation(int i=20, int j=4)
        {
            Console.WriteLine(j);
            int product = i * j;
            //int sum = i + j;
            //int Quatient = i / j;
            //int different = i - j;
            return product;
            //return sum;
            //return Quatient;
            //return different;
        }
    }
}
