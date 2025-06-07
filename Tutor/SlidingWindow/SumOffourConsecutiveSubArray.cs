using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SlidingWindow
{
    internal class SumOffourConsecutiveSubArray
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 5, 7, 2, 5, 1, 3, 2 };
            //Console.WriteLine(BruteForceApproach(nums));
            Console.WriteLine(OptimizedOne(nums));
        }

        private static int BruteForceApproach(int[] nums)
        {
            int maxsum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < nums.Length - 4; j++)
                {
                    sum += nums[j];
                    if (sum > maxsum)
                    {
                        maxsum = sum;
                    }
                }
            }
            return maxsum;
        }

        private static int OptimizedOne(int[] nums)
        {
            int n= nums.Length;
            int subArray = 4;
            int sum = 0;
            int left = 0;
            int right = subArray;
            int max = int.MinValue;

            for (int i = 0; i < subArray; i++)
            {
                sum = sum + nums[i];
            }
            max = sum;

           for ( right = subArray; right < n; right++)
            {
                sum = sum - nums[left]+nums[right];
                left++;
                max = Math.Max(max, sum);
            }
            return max;

        }
    }
}
