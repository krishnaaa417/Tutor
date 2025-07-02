using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DSA_Bootcamp.DAY_1_Homework_Arrays
{
    internal class TraversingArray
    {
        static void Main(string[] args)
        {
            int[] nums = { 22, 44, 2, -1, 99 };
            // BasicOperation(nums);
            Console.WriteLine(SumOfElements(nums));

        }

        private static void BasicOperation(int[] nums)
        {
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("index"+i+":"+nums[i]);
            }
        }

        private static int SumOfElements(int[] nums)
        {
            int sum = 0;
           int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
