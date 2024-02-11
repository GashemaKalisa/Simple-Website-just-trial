using System;


namespace Console_Application_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
        

            Console.WriteLine("FOR MULTIPLICATION");
            Console.WriteLine("enter a number");
            int mult = Convert.ToInt32(Console.ReadLine());//entering number from keyboard
            int fift =50;
            Console.WriteLine("the product of " + mult + "* 50 is ");
            Console.WriteLine(mult*fift);
            //or we have to declare the variable that hold the answer
            //Console.WriteLine("enter a number");
            //int mult = Convert.ToInt32(Console.ReadLine());
            //int fift = 50;
            //int ans = mult * fift;
            //Console.WriteLine(ans);
            //Console.ReadLine();

            //for addition
            Console.WriteLine("For addition");
            Console.WriteLine("enter a number");
            int addi = Convert.ToInt32(Console.ReadLine());//entering number from keyboard
            int user = 25;
            Console.WriteLine("sum of " + addi + " plus 25 is ");
            Console.WriteLine(addi + user);


         // for division
            Console.WriteLine("For divisition");
            Console.WriteLine("enter a number");
            float adiv =Convert.ToInt32(Console.ReadLine());//entering number from keyboard
            float useer = 12.5f;
            Console.WriteLine("the Quatient of  " + adiv + "divided by 12.5 is ");
            Console.WriteLine(adiv / useer);


            //for checking greater than
            Console.WriteLine("For checking if the number is greater than 50");
            Console.WriteLine("enter a number");
            int gr = Convert.ToInt32(Console.ReadLine());//entering number from keyboard
            Console.WriteLine(gr > 50);


            //for modulas
            Console.WriteLine("enter a number");
            int modulas = Convert.ToInt32(Console.ReadLine()); //entering number from keyboard
            int res = modulas % 7;//variable res store the remainder
            Console.WriteLine(modulas + " divid by 7 the remainder is  " + res);
            Console.ReadLine();
        }
    }
}
