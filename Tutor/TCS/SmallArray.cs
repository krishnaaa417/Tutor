using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TCS
{
    internal class SmallArray
    {
        static void Main(string[] args)
        {
            int[] nums = { 22, 341, 32, 0, 1 };
            Console.WriteLine("smallest number in the given array.."+SmallestNumberIntheArray(nums));
        }

        public static int SmallestNumberIntheArray(int[] nums)
        {
            int n  = nums.Length;
            int max = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] < max)
                {
                    max = nums[i];
                }
            }
            return max;
        }
    }
}
