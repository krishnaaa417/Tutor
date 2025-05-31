using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TwoPointerApproach
{
    internal class SubArraySum
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            int k = 3;
            Console.WriteLine(SubArray(nums,k));
        }

        private static int SubArray(int[] nums, int k)
        {
            int n = nums.Length;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum = sum + nums[j];
                    if (sum == k)
                    {
                        count++;
                    }
               
               }
               
            }
            return count;
        }

        //private static int SubOptimize(int[] nums, int k)
        //{

        //}
    }
}
