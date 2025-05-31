using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TwoPointerApproach
{
    internal class MaximumSubArray
    {
        static void Main(string[] args)
        {
            int[] nums = { -2,1,-3,4,-1,2,1,-5,4};
            Console.WriteLine(BruteForceApproach(nums));

        }

        private static int BruteForceApproach(int[] nums)
        {
            int n = nums.Length;
            int maxSum = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
               sum = sum + nums[i];
                maxSum = Math.Max(maxSum, sum);
            }
            return maxSum;
        }
    }
}
