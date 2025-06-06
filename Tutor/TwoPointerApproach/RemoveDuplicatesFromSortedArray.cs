using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TwoPointerApproach
{
    internal class RemoveDuplicatesFromSortedArray
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2 ,2,33,44,44};
            Console.WriteLine(BruteForceApproach(nums));
        }

        private static int BruteForceApproach(int[] nums)
        {
            int n = nums.Length;
            if (n == 0) return 0;

            int uniqueCount = 1; // First element is always unique

            for (int i = 1; i < n; i++)
            {
                bool isDuplicate = false;

                // Compare nums[i] with all previous unique elements
                for (int j = 0; j < uniqueCount; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                // If unique, store it in the array
                if (isDuplicate == false)
                {
                    nums[uniqueCount] = nums[i];
                    uniqueCount++;
                }
            }

            // Print unique values correctly
            Console.WriteLine("Array with unique values:");
            for (int i = 0; i < uniqueCount; i++)
            {
                Console.Write(nums[i] + " ");
            }

            Console.WriteLine("-----");

            return uniqueCount; // New length of unique numbers
        }
       
    }
}
