using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TCS
{
    internal class PivotIndex
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 7, 3, 6, 5, 6 };
            Console.WriteLine(OptimisedApproach(nums));

        }

        private static int OptimisedApproach(int[] nums)
        {
            int n = nums.Length;
            int totalsum = nums.Sum();
            int leftsum = 0;
           for (int i = 0; i < n; i++)
            {
                int rightsum = totalsum - leftsum - nums[i];
                if ((rightsum == leftsum))
                
                    return i;
                leftsum = leftsum + nums[i];
            }
            return -1;
        }
    }
}
