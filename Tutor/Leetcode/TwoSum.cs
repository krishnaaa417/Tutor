using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Leetcode
{
    internal class TwoSum
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3,2,4 };
            int target = 6;
            Console.WriteLine(OptimisedApproach(nums,target));
        }

        private static int[] BruteForceApproach(int[] nums,int target)
        {
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 0, 0 };
        }

        private static int[] OptimisedApproach(int[] nums, int target)
        {
            int n = nums.Length;

            var pairs = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (pairs.ContainsKey(target - nums[i]))
                {
                    return new int[] { pairs[target - nums[i]], i };
                }
                else
                {
                    pairs.TryAdd(nums[i], i);
                }
            }
            return default;
        }
    }
}
