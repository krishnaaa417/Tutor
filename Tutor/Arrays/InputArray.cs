using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Arrays
{
    internal class InputArray
    {
        static void Main(string[] args)
        {
            int[] nums = { 44, 3, 1, 202, 34, 2 ,14};
            // Console.WriteLine(SumOfElements(nums));
            //Console.WriteLine(MaxInArray(nums));
            //Console.WriteLine(MinInArray(nums));
        }

        private static int SumOfElements(int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }
            return sum;
        }

        private static int MaxInArray(int[] nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        private static int MinInArray(int[] nums)
        {
            int min = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            return min;
        }


    }
}
