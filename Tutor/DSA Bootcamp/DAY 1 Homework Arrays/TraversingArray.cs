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
            

        }

        private static void BasicOperation(int[] nums)
        {
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("index" + i + ":" + nums[i]);
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

        private static double AverageOfElements(int[] nums)
        {
            double average = 0.0;
            int sum = 0;
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                sum = sum + nums[i];
            }
            average = (double)sum / n;
            return average;
        }

        private static int MinValue(int[] nums)
        {
            int min = int.MaxValue;
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            return min;
        }

        private static int MaxValue(int[] nums)
        {
            int max = int.MinValue;
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        private static int COuntOfEvenNumber(int[] nums)
        {
            int count = 0;
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        private static bool Searching(int[] nums, int target)
        {
            bool b = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (target == nums[i])
                {
                    b = true; break;
                }
            }
            return b;
        }

        private static void ReverseOrder(int[] nums)
        {
            int n = nums.Length;
            for (int i = n-1; i >= 0; i--)
            {
                Console.WriteLine(nums[i]);
            }
        }

    }

}
