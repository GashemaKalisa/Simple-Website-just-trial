using System;


namespace ConsoleApp_for_do_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //starting of do while loop
            int num = 1;
            do
            {
                Console.WriteLine("is in the loop");
                num++;//increament of variable num
            }
            while (num < 5);

            //while loop
            int numb = 1;
            while(numb < 3)
            {
                Console.WriteLine("counting numbers");
                numb++;//increament of variable numb
            }
            Console.ReadLine();
        }
    }
}
