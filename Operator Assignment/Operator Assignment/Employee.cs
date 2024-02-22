using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Assignment
{
    //Creation of Employee class with Id firstname and lastname Properites
    class Employee
    {
        public int Id { get; set; }
        //public int Id2 { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Declaration of boolean
        public static bool operator == (Employee Id1,Employee Id2)
        {
            if (Id1.Id== Id2.Id)//condition in equality
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Employee Id1, Employee Id2)//declariton of ineqality 
        {
            if (Id1.Id == Id2.Id)
            {
                return false;
            }
            return true;
        }
    }
}
        
        
    
   

