using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Leetcode
{
    internal class FindFirstAndLastPosition
    {
        static void Main(string[] args)
        {
            int[] nums = {33,3,2,2,44,2,44  };
            int target = 2;
            Console.WriteLine($"[{string.Join(", ", FindFirstAndLast(nums, target))}]");

        }

        private static int[] FindFirstAndLast(int[] nums,int target)
        {
            int n = nums.Length;
            
            
            if (nums == null && nums.Length == 0)
            {
                return new int[] { -1, -1 };
            }

            int left = -1;
            int right = -1;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] == target)
                {
                    left = i;
                    break;
                }
            }

            if (left != -1)
            {
                for (int i = nums.Length - 1; i >= left; i--)
                {
                    if (nums[i] == target)
                    {
                        right = i;
                        break;
                    }
                }
            }
            return new int[] { left, right };
        }
    }
}
