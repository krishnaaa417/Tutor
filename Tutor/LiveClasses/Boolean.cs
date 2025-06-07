using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.LiveClasses
{
    internal class Boolean
    {
        static void Main(string[] args)
        {
            //bools();
            // Integer();
            int a = (6 < 5) ? 11 :  1;
            Console.WriteLine(a);
        }

        private static void bools()
        {
            Console.WriteLine("please enter a boolean value.");
            bool b = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("your value." + b);
        }

        public static void Integer()
        {
            Console.WriteLine("pleasse enter a number..");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your number is."+a);
        }
    }
}
