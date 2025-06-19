using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Leetcode
{
    internal class BestTimeToBuyStockAndSellStock
    {
        static void Main(string[] args)
        {
            int[] nums = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(OptimisedSolution(nums));
        }

        private static int OptimisedSolution(int[] prices)
        {
            int n = prices.Length;
            // first I need print min value
            int min = prices[0];
            int max = 0;

            for (int i = 1; i < n; i++)
            {
                if (prices[i] > min)
                {
                    max = Math.Max(max, prices[i]-min);
                }

                min = Math.Min(min, prices[i]);

                
            }
            return max;
        }
    }
}
