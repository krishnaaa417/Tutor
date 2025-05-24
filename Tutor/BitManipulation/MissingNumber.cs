using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.BitManipulation
{
    internal class MissingNumber
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 0, 1 };
            // Console.WriteLine(FindMissingNumber(nums));
            Console.WriteLine(MissingNumberAnotherApproach(nums));
        }

        private static int FindMissingNumber(int[] nums)
        {
            int output = 0;

            for (int i = 0; i <= nums.Length; i++)
            {
                output = output ^ i;
            }
          //  return output;

            for (int i = 0; i < nums.Length; i++)
            {
                output = output ^ nums[i];
            }
            return output;


        }

        private static int MissingNumberAnotherApproach(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count = count + nums[i];
            }

            int actualvalue = (nums.Length * (nums.Length + 1)) / 2;

            return actualvalue - count;
        }
    }
}
