using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TwoPointerApproach
{
    internal class ContainerWithMostWater
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Console.WriteLine(MaxContainerWater(nums));
        }

        private static int MaxContainerWater(int[] nums)
        {
            int n = nums.Length;
            int maxWater = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int width = j - i;
                    int height = Math.Min(nums[i], nums[j]);
                    int area = width * height;
                    maxWater = Math.Max(maxWater, area);
                }
            }
            return maxWater;
        }
    }
}
