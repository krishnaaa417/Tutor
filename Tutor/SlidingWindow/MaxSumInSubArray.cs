using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SlidingWindow
{
    internal class MaxSumInSubArray
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, 5, 4, 8, 1, 2, 4, 5, 6 };
            Console.WriteLine(BruteForceApproach(n));
        }

        private static int BruteForceApproach(int[] arr)
        {
          
           int n = arr.Length;
            int subarray = 3;

            int maxsum = 0;

            for (int i = 0; i <= n - subarray; i++)
            {
                int sum = 0;

                for (int j = i; j < i + subarray; j++)
                {
                    sum += arr[j];
                }

                maxsum = Math.Max(maxsum, sum);
            }
            return maxsum;
           

           
           
        }
    }
}
