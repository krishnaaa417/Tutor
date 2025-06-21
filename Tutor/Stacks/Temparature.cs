using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Stacks
{
    internal class Temparature
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };
            int[] result = BruteForceApproach(nums);
            foreach (int i in result)
            {
                Console.WriteLine(i+",");
            }
        }

        private static int[] BruteForceApproach(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        result[i] = j - i;
                        break;

                    }
                  
                }
            }
            return result;
        }

        
    }
}
