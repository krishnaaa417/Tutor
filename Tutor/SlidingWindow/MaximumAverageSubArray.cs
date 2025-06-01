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
            double d = 10.00;
            return  d;
        }
    }
}
