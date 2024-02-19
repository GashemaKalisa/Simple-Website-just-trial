using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    //Interface Name
    interface IQuittable
    {
        string Country { get; set; }
        
         string city { get; set; }

        //Method name
         void Quit();
    }
}
