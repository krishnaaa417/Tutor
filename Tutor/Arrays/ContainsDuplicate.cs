using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Arrays
{
    internal class ContainsDuplicate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of the array:");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[length];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(BruteForceApproach(arr));

        }

        private static bool BruteForceApproach(int[] nums)
        {
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
