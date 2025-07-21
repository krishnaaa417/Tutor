using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.HashMap
{
    internal class CountOfFrequencies
    {
        static void Main(string[] args)
        {
            int[] nums = { 1,2,3,1,2,2};
            int n = nums.Length;
            bool[] filled = new bool[n];
            for (int i = 0; i < n; i++)
            {
                if (filled[i] == true) { continue; }

                int count = 0;

                for (int j = 0; j < n; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                        filled[j]   = true;
                    }
                }

                Console.WriteLine($"Element {nums[i]} occurs {count} times");
            }
        }

        
    }
}
