using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TCS
{
    internal class LengthOfOddSubArray
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 4, 2, 5, 3 };
            //Console.WriteLine(Lengthofodd(nums));
            Checking(nums);
            
        }

        private static int Lengthofodd(int[] arr)
        {
           // int n = nums.Length;
            int n = arr.Length;
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                int sum = arr[i];
                int len = 0;
                ans = ans + sum;
                for (int j = i + 1; j < n; j++)
                {
                    sum = sum + arr[j];
                    if ((j - i + 1) % 2 == 1)
                    {
                        ans = ans + sum;
                    }
                }

            }
            return ans;

        }

        private static void Checking(int[] arr)
        {
            int n = arr.Length; 
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if((j-1+1) %2 ==1) { Console.Write(j); }
                }
                Console.WriteLine();
            }
        }
    }
}
