using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class MathOperation1
    {
        //crate a method that takes two intergers as parameters
        //Make on parameter optional by providing a default value
        public int MathOperation(int i, int j = 1)
        {
            int result = i * j;
            return result;
        }
    }
}
