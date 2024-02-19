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
            console.WriteLine("Then secind number is ");
            Console.WriteLine(j);
            int product = i * j;
            Console.WriteLine("The product is ");
            Console.WriteLine("product");
            return product;
           
        }
    }
}
