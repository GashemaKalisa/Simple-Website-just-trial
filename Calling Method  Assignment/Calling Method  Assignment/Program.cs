using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Method__Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You've encountered Groznyi the Brigad and he launches a surprise attack. ");
            Console.WriteLine("Input your defense stat:");
            int defence = Convert.ToInt32(Console.ReadLine());
            int enemy_damage = MathMethods.Defense(defence);
            Console.WriteLine("You have taken " + enemy_damage + "HP of damage");
            Console.WriteLine("Your healer, Serra is near by. She heals you with her staff. ");
            Console.WriteLine("Input you healer's magic stat:");
            int magic = Convert.ToInt32(Console.ReadLine());
            int hitpoints = MathMethods.heal(magic);
            Console.WriteLine("you have been healed for " + hitpoints + " HP");
            Console.WriteLine("Now it's your turn to counter attack.");
            Console.WriteLine("Input your strength stat: ");
            int strenth = Convert.ToInt32(Console.ReadLine());
            int damage = MathMethods.Attack(strenth);
            Console.WriteLine("you have landed a critical attack and dealt " + damage + "HP worth of damge. ");
            Console.ReadLine();

        }
    }
}
