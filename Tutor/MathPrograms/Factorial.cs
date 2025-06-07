using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.MathPrograms
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please a factorial number");
            int fact = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fact(fact));

        }

        private static int Fact(int n)
        {
            int count = 1;

            try
            {
                for (int i = 1; i <= n; i++)
                {
                    count = count * i;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return count;
        }
    }
}
