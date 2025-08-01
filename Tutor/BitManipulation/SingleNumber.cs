using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.BitManipulation
{
    internal class SingleNumber
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 1 };
            Console.WriteLine(SingleNumbers(nums));
        }

        private static int SingleNumbers(int[] nums)
        {
            int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                temp = temp ^ nums[i];
            }
            return temp;
        }

        private static int BruteForceApproach(int[] nums)
        {
            Array.Sort(nums);
            int temp = 0;
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i = 1; j < n; j++)
                {
                    if (nums[i] != nums[j])
                    {
                        temp = nums[i];
                    }
                }
            }
            return temp;
        }
    }
}
