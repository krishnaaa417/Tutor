using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment1
{
    internal class EligibleForMarriage
    {
        static void Main(string[] args)
        {
            EligibleForMarriages();
        }

        public static void EligibleForMarriages()
        {
            Console.WriteLine("please enter girl age");
            int girl_age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter boy age");
            int boy_age = Convert.ToInt32(Console.ReadLine());

            if (girl_age > 18 && boy_age > 21)
            {
                Console.WriteLine("Yes,Both are eligible for marriage");
            }
            else
            {

                Console.WriteLine("No ,they are not eligible for marriage");
            }
        }
    }
}
