using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Sorting_Algorithms
{
    internal class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 5, 1, 3, 2 };
            var result = BruteForceApproach(nums);

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            
        }

        private static int[] BruteForceApproach(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int temp = nums[i];
                        nums[i]= nums[j];
                        nums[j]= temp;
                    }
                }
                
            }
            return nums;
        }
    }
}
