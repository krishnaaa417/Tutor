using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Queues
{
    internal class RemoveDuplicatesInSortedArray
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 2, 3, 3, 3, 4, 55, 55, 88, 999, 999, 1000 };
            int n = nums.Length;
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] != nums[index])
                {
                    index++;
                    nums[index] = nums[i];
                }
            }
            
            for (int i = 0; i <= index; i++)
            {
                Console.WriteLine(nums[i]+",");
            }

        }

      
    }
}
