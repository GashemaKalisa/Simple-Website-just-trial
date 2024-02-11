using System;

namespace Daily_Report_Application
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Academy of Learning Career College.");
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine("What is your Name ?");
            string yourname = Console.ReadLine();     //declaration of name   
            Console.WriteLine("What course are you on?");
            string course_name = Console.ReadLine();//declaration of course_name
            Console.WriteLine("What page number (please insert number).");
            int p_number = Convert.ToInt32(Console.ReadLine());//declaration this allows to insert numbers
            Console.WriteLine("Dou you need help with anything? Please answer \"true\" or \"false\".");
            string trueorfalse = Console.ReadLine();//here you declare as normal after you use boolean data type after this
            bool tobebool = bool.Parse(trueorfalse);//this code helps to get boolean answer
            Console.WriteLine("Were there any positive experiences you'd like to share ? Please give specifics.");
            string experience = Console.ReadLine();//declaration of experiance
            Console.WriteLine("is there any other feedback you'd like to provide? please be specific.");
            string feedback = Console.ReadLine();//declarion of feedback
            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt32(Console.ReadLine());//declaration this allows to insert numbers
            Console.WriteLine("Thank you for your answers. An Instrudtor will respond shortly.have a great day!");
            Console.ReadLine();//stable on the screen
       



        }
    }
}
