using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Sorting_Algorithms
{
    internal class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] nums = { 22, 12, 10, 2, 1, 432, 20 };
            var sortedarray = BruteForceApproach(nums);
            foreach (int i in sortedarray)
            {
                Console.WriteLine("Sorted Array."+i+"..");
            }
        }

        private static int[] BruteForceApproach(int[] nums)
        {
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;
        }
    }

    
}
