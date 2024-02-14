using System;
using System.Collections.Generic;
using System.Text;



namespace Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // For part one
            //one dimension
            string[] sentence =
            {
                "Hello every one ",
                "My name is Gashema Kalisa a student in "
            };
            string[] location_with_option =
            {
                "College ",
                " am learnig Software and Web development"
            };

            List<String> response = new List<string>();

            //ask the user to input some text.
            Console.WriteLine("enter greeting  ");
            response.Add(Console.ReadLine());
            Console.WriteLine("Enter one word that can describe you: ");
            response.Add(Console.ReadLine());

            // loop creation
            for (int i = 0; i < sentence.Length; i++)
            {
                sentence[i] += response[i];
                Console.WriteLine(sentence[i] + location_with_option[i]);

                //for part two
                //i--;// for part two to make it infinite you decreament the iteration in for loop

            }

            Console.ReadLine();


            //part 3

            Console.WriteLine("is that a ghost?! ");
            StringBuilder boo = new StringBuilder();
            boo.Append("B");
            //creation of loop comparison
            while (boo.Length < 10)
            {
                boo.Append("o");
            }
            boo.Append("!");
            Console.ReadLine();
            Console.WriteLine(boo);
            Console.ReadLine();
            StringBuilder me = new StringBuilder();
            me.Append("ma");
            //Add a loop of camparison
            while (me.Length <= 10)
            {
                me.Append("my");
            }
            me.Append("!");
            Console.WriteLine(me);
            Console.ReadLine();

            //part 4

            // to create a list

            List<string> teams = new List<string>()
            {
                "Bucks","Raptors","Celtics","Heat","Pacers","76ers","Nets","Magic",
                "Wizards","Hornts","Bulls","Knicks","Pistons","Hawks","Cavaliers"
            };
            Console.WriteLine("NBA Eastern Conference Standing");
            //Ask the user to  in put text to search for in the List.

            int standing = 0;
            bool isvalid = false;
            int index = 0;

            //creation a loop that iterates through the list and then display the index
            while (!isvalid)
            {
                int ii = 0;
                string teamrequest = Console.ReadLine();
                foreach (string team in teams)
                {

                    if (teamrequest == team)
                    {
                        standing = ii + 1;
                        index = ii;
                    }
                    ii++;
                }

                //Add code to that above loop that tells a user if they put in text that isn't in the list
                if (standing == 0)
                {
                    Console.WriteLine("that is not a valid team name. enter again");

                }
                //add code to athat above loop that stops it from executing once a match has been found.
                else
                {
                    isvalid = true;
                }
            }
            Console.WriteLine("Processing .. Index is : " + index + " .so..");
            Console.WriteLine("Standing is : " + standing);
            Console.ReadLine();

            //Part 5
            //create a list of strings that has at least two identical strings in the list

            List<string> tables = new List<string>()
            {
                "Reserved","Vacant","Taken","Vacant","Vacant","Reserved","Taken"
            };
            Console.WriteLine("Welcome to swell Taco! \n Due to COVID-19 we have a computerized check-in. \n I you have a resevation type  "
                + "\"Reserved\".\n If you are hoining a party that is already here type \"Taken\".\nOtherwise type \"Vacant\".");
            //Ask the user to select text to search for in the list.
            Console.WriteLine("Enter selection: ");
            string selection = Console.ReadLine();
            while (!(selection == "Vacant" || selection == "Reserved" || selection == "Taken"))
            {
                //Add code that tells a user if they put in text that isn't in the List.
                Console.WriteLine("Please enter one of the 3 choices: ");
                selection = Console.ReadLine();
            }
            Console.WriteLine("The tables that match your selection are numbered: ");

            //create a loop that iterates through the loop and then display the indeces of the array 
            //that contain matching text on the screen
            for (int i3 = 0; i3 < tables.Count; i3++)
            {
                if (selection == tables[i3])
                {
                    Console.WriteLine(i3);
                }
            }
            Console.ReadLine();


            //part 6

            //create a list of strings that has at least two identical strings in the List

            List<string> names = new List<string>() { "Bob", "Jim", "Tiffany", "Bob", "Kat", "Mary", "Mary" };
            List<string> repeatCheck = new List<string>();
            Console.WriteLine("Class Roster");
            //create a foreach loop that evaluates each item in the list, and dispays a message showing the string and whether
            //or not it has already appeare din the list.
            foreach (String name in names)
            {
                Console.WriteLine(name);
                if (repeatCheck.Contains(name))
                {
                    Console.WriteLine("This name has been reapted.\n Use Lst name initial when referring to this student.");
                }
                else
                {
                    Console.WriteLine("This noame has not been repeated.");
                }
                repeatCheck.Add(name);
            }
            Console.ReadLine();
           

        }
    }
}
