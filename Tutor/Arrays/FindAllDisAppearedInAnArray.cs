using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Arrays
{
    internal class FindAllDisAppearedInAnArray
    {
        static void Main(string[] args)
        {
            int[] nums = { 4,3,2,7,8,2,3,1}; // 5 && 6
            Console.WriteLine(BruteForceApproach(nums));
        }

        public static IList<int> BruteForceApproach(int[] nums)
        {
            List<int> result = new List<int>();
           // 1st step -> need to run the loop from 1 - range
           for (int i = 1; i <= nums.Length; i++)
            {
                bool b = false;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == i)
                    {
                        b= true;
                        break;
                    }
                }
                if (b == false)
                {
                    result.Add(i);
                }
            }
           return result;

        }
    }
}
