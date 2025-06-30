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
            Console.WriteLine(SlidingWindowApproach(n));
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

        private static int SlidingWindowApproach(int[] arr)
        {
            int n = arr.Length;
            int subarray = 3;
            if (n < subarray) return 0; // Handle edge case where array size is smaller than subarray size

            int left = 0;
            int sum = 0;
            int maxx = int.MinValue;

            // Compute initial sum of first 'subarray' elements
            for (int i = 0; i < subarray; i++)
            {
                sum += arr[i];
            }
            maxx = sum;

            // Sliding Window technique
            for (int right = subarray; right < n; right++)
            {
                sum = sum - arr[left] + arr[right]; // Slide the window by removing leftmost element and adding rightmost
                left++; // Move the window forward
                maxx = Math.Max(maxx, sum); // Update max sum
            }

            return maxx; // Return the maximum found

        }
    }
}
