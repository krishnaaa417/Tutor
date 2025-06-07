using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.MathPrograms
{
    internal class GCF
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter a number");
            int k = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && k %i ==0)
                {
                   count = i;
                }
            }
            Console.WriteLine(count);
        }
    }
}
