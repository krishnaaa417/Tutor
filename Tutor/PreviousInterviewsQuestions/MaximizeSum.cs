using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.PreviousInterviewsQuestions
{
    internal class MaximizeSum
    {
        static void Main(string[] args)
        {
            int[] nums = {  75, 61, 32, 15, 10, 9, 7, 1 };
            BruteForce(nums) ;
        }

        private static void BruteForce(int[] nums)
        {
            int n = nums.Length;
            int size = 3;
            int target = 26;
            int sum = 0;
           

            for (int i = 0; i < size; i++)
            {
                sum += nums[i];
            }
            if (sum == target)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(nums[i]);
                }
            }

            for (int i = size; i < n; i++)
            {
                sum = sum - nums[i - size] + nums[i];

                if (sum == target)
                {
                    for (int j = i - size; j <= i; j++)
                    {
                        Console.WriteLine(nums[j]);
                    }
                }
            }

        }
    }
}
