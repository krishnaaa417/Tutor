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
            Console.WriteLine(BruteForceApproach(nums));
        }

        private static int BruteForceApproach(int[] nums)
        {
            int maxsum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < nums.Length-4; j++)
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
    }
}
