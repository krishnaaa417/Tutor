using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.BasicLoops
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            for(int i=0; i <= 10; i++)
            {
                int c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}
