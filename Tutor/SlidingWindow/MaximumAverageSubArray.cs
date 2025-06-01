using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SlidingWindow
{
    internal class MaximumAverageSubArray
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 12, -5, -6, 50, 3 };
            int k = 4;
            Console.WriteLine("MaximumAverageSubArray.."+BruteForceApproach(nums,k));
        }

        private static double BruteForceApproach(int[] nums, int k)
        {
           int n = nums.Length;
            double maxAverage = 0.00;
            for (int i = 0; i < n - k + 1; i++)
            {
                double sum = 0;
                for (int j = i; j < i + k; j++)
                {
                    sum += nums[j]; 
                }
                double average = sum / k;

                maxAverage = Math.Max(maxAverage, average);
            }
            return maxAverage;
        }
    }
}
