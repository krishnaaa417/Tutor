using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.HackerRankTest
{
    internal class MaxmizeTreasure
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 5, 1, 4 };
            Max(nums, 3);
        }

        private static void Max(int[] nums,int extracoins)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum = nums[i] + extracoins;
            }
            Console.WriteLine(sum);

        }
    }
}
