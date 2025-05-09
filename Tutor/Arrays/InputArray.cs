using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Arrays
{
    internal class InputArray
    {
        static void Main(string[] args)
        {
            //int[] nums = { 44, 3, 1, 202, 34, 2 ,14};
            //// Console.WriteLine(SumOfElements(nums));
            ////Console.WriteLine(MaxInArray(nums));
            ////Console.WriteLine(MinInArray(nums));
            ////Console.WriteLine(SecondLargestNumber(nums));
            //Console.WriteLine(ThirdValue(nums));

            Console.WriteLine("please enter a number of size of the array do you want!");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("please enter the age.");
            array[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the age.");
            array[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the age.");
            array[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the age.");
            array[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the age.");
            array[4] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }

        private static int SumOfElements(int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }
            return sum;
        }

        private static int MaxInArray(int[] nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        private static int MinInArray(int[] nums)
        {
            int min = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            return min;
        }

        private static int SecondLargestNumber(int[] nums)
        {
            int firstvalue = 0;
            int secondvalue = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > firstvalue)
                {
                    secondvalue = firstvalue;
                    firstvalue = nums[i];
                }
                else if (nums[i] > secondvalue && nums[i] != firstvalue)
                {
                    secondvalue = nums[i];
                }
            }
            return secondvalue;
        }

        public static int ThirdValue(int[] nums)
        {
            int firstvalue = 0;
            int secondvalue = 0;
            int thirdvalue = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > firstvalue)
                {
                    thirdvalue = secondvalue;
                    secondvalue = firstvalue;
                    firstvalue = nums[i];
                }

                else if (nums[i] > thirdvalue && nums[i] > secondvalue && nums[i] != secondvalue && nums[i] != firstvalue)
                {
                    nums[i] = thirdvalue;
                }
            }
            return thirdvalue;

        }


    }
}
