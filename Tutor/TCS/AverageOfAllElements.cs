using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TCS
{
    internal class AverageOfAllElements
    {
        static void Main(string[] args)
        {
            int[] nums = {1,2,3,4,5};
            Console.WriteLine("Average-Of-All-Elements.."+Avg(nums));
            
        }

        private static double Avg(int[] nums)
        {
            int n = nums.Length;

            if(nums == null || n==0 ) return 0.0;

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += nums[i];
            }

            double avg = sum / (double)n;

            return avg;
        }
    }
}
