using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.BasicLoops
{
    internal class Factorial
    {
        static void Main(string[] args)
        {

            int fact = 1;
            for(int i = 5; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
