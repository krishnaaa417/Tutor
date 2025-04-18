using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Assignment1
{
    internal class Tax
    {
        static void Main(string[] args)
        {
            Ternary();
        }

        private static void Ternary()
        {
            Console.WriteLine("please enter your amount");
            int amount = Convert.ToInt32(Console.ReadLine());

            int tax = amount > 50000 ? (int)(0.10 * amount) : (int)(0.05 * amount);

            Console.WriteLine("tax."+tax);

        }
    }

   
}
