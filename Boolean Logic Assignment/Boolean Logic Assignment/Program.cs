using System;


namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Approval for car insurance");
            Console.WriteLine("What is your age ?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? (Yes or No)");
            string response = Console.ReadLine().ToLower();//variable response hold the answer from key board
            bool dui = response == "Yes";
            Console.ReadLine();

            Console.WriteLine("How many Speeding tickets do you have ?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is the car approved ?");
            bool approved = age > 15 && !dui && (tickets <= 3);
            Console.WriteLine(approved);
            Console.ReadLine();


        }
    }
}
