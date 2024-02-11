using System;
using System.Text;

namespace String_Assignment
{
    class Program
    {
        static void Main()
        {
            //starting of program
            Console.WriteLine("enter first name");
            string fname = Convert.ToString(Console.ReadLine());//requsting user to enter first name
            Console.WriteLine("enter you last name");
            string lname = Convert.ToString(Console.ReadLine()); //requsting user to enter last name
            Console.WriteLine("you full name is " + fname + " " + lname ); //concantinate nam

            Console.WriteLine("you full name in uppercase " + fname.ToUpper() + " " + lname.ToUpper()); //concantinate names and resulting in upper case
       //starting of string builder 
       //N.B to using string builder you need to use "using system.Text" at the start
            StringBuilder sb = new StringBuilder(fname);
            sb.Append(" "+lname);//adding last name to first name
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
