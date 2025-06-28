using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TCS
{
    internal class LargestNumber
    {
        static void Main(string[] args)
        {
            int[] nums = { 22, 341, 32, 0, 1 ,9030};
            Console.WriteLine("Largest-Number in the array.." + SecondLargestNumber(nums));
        }

        private static int LargestNumberIntheGivenArray(int[] nums)
        {
            int n = nums.Length;
            int min = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] > min)
                {
                    min = nums[i];
                }
            }
            return min;
        }

        private static int SecondLargestNumber(int[] nums)
        {
            
            int n = nums.Length;
            int largest = int.MinValue;
            int secondlargest = 0;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] > largest)
                {
                    secondlargest = largest;
                    largest = nums[i];
                }
                else if (secondlargest < largest && nums[i] > largest)
                {
                    secondlargest = nums[i];
                }
            }
            return secondlargest;
        }
    }
}
