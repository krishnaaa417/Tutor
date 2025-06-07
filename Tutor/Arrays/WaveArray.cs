using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Arrays
{
    internal class WaveArray
    {
        static void Main(string[] args)
        {
            int[] nums = { 24, 40, 345, 432, 444, 555 };
           WavsArray(nums);
        }

        private static void WavsArray(int[] nums)
        {
            for (int i = 0; i <nums.Length; i = i + 2)
            {
                int temp = nums[i];
                nums[i] = nums[i + 1];
                nums[i + 1] = temp;
            }
           
        }
    }
}
