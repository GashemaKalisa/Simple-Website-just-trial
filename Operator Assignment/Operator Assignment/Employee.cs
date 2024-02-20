using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Assignment
{
    class Employee
    {
        int Id1, Id2;
        string Firstname, Lastname;
        public Employee()
        {
            this.Id1 = 001;
            this.Id2 = 002;
            this.Firstname = "Gashema";
            this.Lastname = "Kalisa";

        }
        public Employee(int Id1, int Id2,string FirstNames,string LastName)
        {
            this.Id1 = Id1;
            this.Id2 = Id2;
            //this.FirstNames = FirstNames;
            //this.LastName = LastName;
        }
        public bool Operator  (Id1,Id2)
        {
            if(Id1 == Id2) 
            {
                Console.WriteLine("First ID is equal to Second Id");
                Console.WriteLine(Firstname);
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public bool Operator(Id1, Id2)
        {
            if (Id1 != Id2)
            {
                Console.WriteLine("First ID is not equal to Second Id");
                Console.WriteLine(Lastname);
                return true;
            }
            else
            {
                return false;
            }

        }

    }
 //       public int ope Id { get; set; }
 //       public int Id2 { get; set; }
 //       public string FirstName { get; set; }
 //       public string LastName { get; set; }
 //       public Employee()
 //       {
 //           this.Id = 001;
 //           this.Id2 = 002;
 //       }

 //       public static bool opera == (Employee Id, Employee Id2)
            
 //           {
 //           if(Id== Id2){
 //           return true;
            
 //            }
 //           else{
 //           return false;
 //           }
 //       public static bool opera !=(Id, Id2)
 //           {
 //           if(Id!=Id2){
 //           return false;
 //           }
 //           else{
 //           return true;
 //           }
             
	//{

	//}

        }
        
        
    
   

