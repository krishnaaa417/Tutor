using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TwoPointerApproach
{
    internal class CountPairs
    {
        static void Main(string[] args)
        {
            int[] nums = { -6, 2, 5, -2, -7, -1, 3 };
            int target = -2;
            Console.WriteLine(BruteForce(nums,target));
        }

        private static int BruteForce(int[] nums, int target)
        {
            int n = nums.Length;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] + nums[j] < target)
                    {
                        count++;
                    }
                }
            }
           return count;
        }
    
        private static int OptimizedApproach(int[] nums, int target)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int count = 0;
            int left = 0;
            int right = n - 1;

            while (left < right)
            {
                if (nums[left] + nums[right] < target)
                {
                    count = count + (right-left);
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return count;
        }
    }

}
