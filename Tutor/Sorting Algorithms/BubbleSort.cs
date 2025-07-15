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
            int[] nums = { 2,0,2,1,1,0};
            var result = OptimizedApproach(nums);

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
                for (int j = i + 1; j < nums.Length; j++)
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

        private static int[] OptimizedApproach(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j+1] = temp;   
                    }
                }
            }
            return nums;
        }
    }
}
