using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.BinarySearch
{
    internal class DryRUn1
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 0, 3, 5, 9, 12 };
            int target = 9;
            Console.WriteLine();
        }

        public int search(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
    }
}
