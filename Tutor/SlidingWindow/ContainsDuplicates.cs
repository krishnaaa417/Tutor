using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SlidingWindow
{
    internal class ContainsDuplicates
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1, 2, 3 };
            int k = 2;
            Console.WriteLine("Contains-Duplicate.."+BruteForceApproach(nums,k));
        }

        private static bool BruteForceApproach(int[] nums,int k)
        {
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if(nums[i] == nums[j] && Math.Abs(i-j) <= k)
                        {
                        return true;
                        }
                }
            }
            return false;
        }
    }
}
