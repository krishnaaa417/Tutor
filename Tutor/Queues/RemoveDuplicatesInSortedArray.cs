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
            int[] nums = new int[] { 1, 1, 2, 2, 44, 55, 66, 77, 88, 88, 99, 999, 999 };
           Remove(nums);
        }

        private static void Remove(int[] nums)
        {
            //two pointer things
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

        /*
         * int[] nums = new int[] {11, 2, 1, 444, 2, 1, 233, 444};
int n = nums.Length;
int uniqueCount = 0;

for (int i = 0; i < n; i++)
{
    bool isDuplicate = false;

    // Check if nums[i] has appeared before
    for (int j = 0; j < uniqueCount; j++)
    {
        if (nums[i] == nums[j])
        {
            isDuplicate = true;
            break;
        }
    }

    // If not a duplicate, place it into the front portion of the array
    if (!isDuplicate)
    {
        nums[uniqueCount] = nums[i];
        uniqueCount++;
    }
}

Console.WriteLine("Unique values:");
for (int i = 0; i < uniqueCount; i++)
{
    Console.Write(nums[i] + " ");
}

         * 
         * 
         * */



    }
}
