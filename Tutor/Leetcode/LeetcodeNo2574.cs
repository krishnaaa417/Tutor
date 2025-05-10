using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Leetcode
{
    internal class LeetcodeNo2574
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 4, 8, 3 };
            Console.WriteLine(string.Join(",",LeftRightDifference(nums)));
            //expected output = 0,10,14,22
        }

        private static int[] LeftRightDifference(int[] nums)
        {
            int n = nums.Length;
            int[] leftsum = new int[n];
            leftsum[0] = 0;

            for (int i = 1; i < n; i++)
            {
                leftsum[i] = leftsum[i - 1] + nums[i-1];
            }
            //return leftsum;

            int[] rightsum = new int[n];
            //int sum = 0;

            //for (int i = n - 1; i >= 0; i--)
            //{
            //    rightsum[i] = sum;
            //    sum += nums[i];
            //}

            // return rightsum;

            // Another-Approach..

            for (int i = n - 2; i >= 0; i--)
            {
                rightsum[i] = rightsum[i + 1] + nums[i + 1];
            }

           return rightsum;
        }
    }
}
