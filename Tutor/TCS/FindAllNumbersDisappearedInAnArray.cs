using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TCS
{
    internal class FindAllNumbersDisappearedInAnArray
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
            Console.WriteLine("set.."+OptimizedApproach(nums));
        }

        private static IList<int> OptimizedApproach(int[] nums)
        {
            int n = nums.Length;
            HashSet<int> visited = new HashSet<int>(nums);
            List<int> list = new List<int>();

            for (int i = 1; i < n; i++)
            {
                if (!visited.Contains(nums[i]))
                {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
