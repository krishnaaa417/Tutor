using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DataTypes
{
    internal class Arithmetic
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("Add.."+Add(a,b));
            Console.WriteLine("Subtract.."+Subtract(a,b));
            Console.WriteLine("Multiplication.."+Multiply(a,b));
            Console.WriteLine("Divison.."+Divide(a,b));
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static int Subtract(int a, int b)
        {
            return a - b;
        }

        private static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
