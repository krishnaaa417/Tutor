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
    }
}
