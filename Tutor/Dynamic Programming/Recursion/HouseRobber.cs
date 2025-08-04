using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Dynamic_Programming.Recursion
{
    internal class HouseRobber
    {
        static void Main(string[] args)
        {
            int[] nums = { 2,7,9,3,1};
            int index = nums.Length;
            int[] dp = new int[index];
            Array.Fill(dp, -1);
            Console.WriteLine(helper(nums,index-1,dp));
        }

        private static int helper(int[] nums, int index, int[] dp)
        {
            if (index == 0)
            {
                return nums[0];
            }
            if (index == 1)
            {
                return Math.Max(nums[0], nums[1]);
            }
            if (dp[index] != -1)
            {
                return dp[index];
            }

            int include = nums[index] + helper(nums, index - 2, dp);
            int exclude = helper(nums, index - 1, dp);
            dp[index] = Math.Max(include, exclude);
            return dp[index];
        }
    }
}
