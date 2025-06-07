using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Leetcode
{
    internal class _1470Shuffle_the_Array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the array size:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[size];

            Console.WriteLine("Please enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Please enter the value of n for shuffling:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] shuffledArray = ShuffleTheArray(nums, n);

            Console.WriteLine("Shuffled Array:");
            Console.WriteLine(string.Join(", ", shuffledArray));
        }

        private static int[] ShuffleTheArray(int[] array,int n)
        {
            int[] output = new int[n * 2];

            for (int i = 0; i < n; i++)
            {
                output[2*i] = array[i];
                output[(2 * i) + 1] = array[i + n];
            }
            return output;
        }
    }
}
