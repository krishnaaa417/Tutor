using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.MathPrograms
{
    internal class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number..");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(SieveErathos(n));
        }

        private static bool NumberIsPrimeOrNot()
        {
            Console.WriteLine("please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static int SieveErathos(int n)
        {
            if(n <= 1) return 0;

            bool[] isPrime = new bool[n];

            for (int i = 2; i < n; i++)
            {
                isPrime[i] = true;
            }

            int count = 0;

            for (int i = 2; i < n; i++)
            {
                if (isPrime[i])
                {
                    count++;

                    for (int j = i * 2; j < n; j = j + i)
                    {
                        isPrime[j] = false;
                    }
                }
            }
            return count;
        }



    }
}
