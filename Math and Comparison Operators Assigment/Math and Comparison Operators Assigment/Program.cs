using System;


namespace Math_and_Comparison_Operators_Assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            //starting of program
            Console.WriteLine("Anonymous Income Comparison Program");

            //for person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
            int hour_rate_for_p1 = Convert.ToInt32(Console.ReadLine());//inter hours rate for person 1
            Console.WriteLine("Hours worked per week");
            int hours_worked_for_p1 = Convert.ToInt32(Console.ReadLine());//inter hours worked for person 1
            Console.ReadLine();

            //for person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            int hour_rate_for_p2 = Convert.ToInt32(Console.ReadLine());//inter hours rate for person 2
            Console.WriteLine("Hours worked per week");
            int hours_worked_for_p2 = Convert.ToInt32(Console.ReadLine());//inter hours worked for person 2
            Console.ReadLine();


            //Annual Salary for Person 1
            Console.WriteLine("Annual Salary of Person 2");
            int annual_salary_for_p1 = (hour_rate_for_p1 * hours_worked_for_p1) * 52;// to multiply by 52 it's because is
                                                                                     // for annual this is for person 1
            Console.WriteLine(annual_salary_for_p1);
            Console.ReadLine();

            //Annual Salary for Person 2

            Console.WriteLine("Annual Salary of Person 1");
            int annual_salary_for_p2 = (hour_rate_for_p2 * hours_worked_for_p2) * 52;// to multiply by 52 it's because is
                                                                                     // for annual   this is for person 2
            Console.WriteLine(annual_salary_for_p2);
            Console.ReadLine();

            Console.WriteLine("Person 1 makes more money than Person 2 ?");
            bool comparison= annual_salary_for_p1 > annual_salary_for_p2;// comparison variable store the boolean answer
            Console.WriteLine(comparison);
            Console.ReadLine();

        }
    }
}
