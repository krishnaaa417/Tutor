using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TwoPointerApproach
{
    internal class ProductOfArrayItself
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            /*
             * 1 = 2*3*4
             * 2 = 1*3*4
             * 3 = 1*2*4;
             * 4 = 1*2*3;
             */
            Console.WriteLine(prefix(nums));
        }

        private static int[] BruteForceApproach(int[] nums)
        {
            int n = nums.Length;
            int[] output = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    
                    if (i != j)
                    {
                        output[i] = nums[i]* nums[j];
                    }
                }
            }
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
            return output;
        }

        private static int[] prefix(int[] nums)
        {
            int n = nums.Length;
            int[] prefix = new int[n];

            prefix[0] = nums[0];

            for (int i = 1; i < n; i++)
            {
                prefix[i] = prefix[i - 1] + nums[i];
            }

            for (int i = 0; i < prefix.Length; i++)
            {
                Console.WriteLine(prefix[i]);
            }
            Console.WriteLine("----");
            return prefix;
        }
    }

    
}
