using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Method__Assignment
{
    class MathMethods
    {
        //Create three methods that take one interger parameter and return an integer
        public static int heal(int magic)
        {
            int hitpoint = magic + 10;
            return hitpoint;
        }
        public static int Defense (int defence)
        {
            int enemy_str = 7;
            int weapon_mt = 11;
            int triangle_bonus = -1;
            int crit_coeff = 1;
            int damage = (enemy_str + (weapon_mt + triangle_bonus) - defence) * crit_coeff;
            return damage;

        }
        public static int Attack(int strength)
        {
            int enemy_def = 4;
            int weapon_mt = 8;
            int triangle_bonus = 1;
            int crit_coeff = 3;
            int damage = (strength + (weapon_mt + triangle_bonus) - enemy_def) * crit_coeff;
            return damage;
        }
    }
}
