using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.BinarySearch
{
    internal class DryRun
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 0, 3, 5, 9, 12 };
            int target = 13;
            Console.WriteLine(FindIndex(nums,target));
        }

        private static int FindIndex(int[] nums, int target)
        {

            //Binary search will work only on sorted-array..
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (right + left) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = right - 1;
                }
            }
            return -1;

        }
    }
}
