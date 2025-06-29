using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TCS
{
    internal class SumOfArray
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Total sum.."+SUm(nums));
        }

        private static int SUm(int[] nums)
        {
            int n = nums.Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
