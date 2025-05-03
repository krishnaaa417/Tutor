using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.LiveClasses
{
    internal class ClassSat
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 8))); // Output: -1,4 (Corrected output)
            Console.WriteLine(string.Join(",", SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 6))); // Output: -1,-1
            Console.WriteLine(string.Join(",", SearchRange(new int[] { }, 0)));                // Output: -1,-1
            Console.WriteLine(string.Join(",", SearchRange(null, 0)));                // Output: -1,-1
            Console.WriteLine(string.Join(",", SearchRange(new int[] { 8, 8, 8 }, 8)));       // Output: 0,2

        }

        public static int[] SearchRange(int[] nums, int target)
        {
            //edge case

            if ( nums == null&& nums.Length == 0 )
            {
                return new int[] { -1, -1 };
            }

            // finding the first occurence
            int left = -1;
            int right = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    left = i;
                    break;
                }
            }

            if (left != -1)
            {
                for (int i = nums.Length - 1; i >= left; i--)
                {
                    if (nums[i] == target)
                    {
                        right = i;
                        break;
                    }
                }
            }

            return new int[] { left, right };
        }


    }
}
