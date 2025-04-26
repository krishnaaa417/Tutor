using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Arrays
{
    internal class MatchingIntegers
    {
        static void Main(string[] args)
        {
            MatchingNumbersInAnArray();
        }

        private static void MatchingNumbersInAnArray()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 5, 34, 4, 3 };
            bool[] visited = new bool[numbers.Length]; // Track counted elements
            int duplicateCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (visited[i]) // Skip already counted elements
                    continue;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        duplicateCount++;
                        visited[j] = true; // Mark this element to avoid counting again
                        break; // Break to ensure we count each duplicate only once
                    }
                }
            }

            Console.WriteLine("Total unique duplicate numbers: " + duplicateCount);
        }
    }
}
