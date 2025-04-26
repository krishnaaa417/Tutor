using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Arrays
{
    internal class ReverseOfAnArray
    {
        static void Main(string[] args)
        {
            // ReverseArray();
            NativeApproach();
        }

        private static void ReverseArray()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            List<int> b = a.Reverse().ToList();
            Console.WriteLine(string.Join(",", b));
        }

        private static void NativeApproach()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            for (int i = a.Length-1; i >= 0; i--)
            {
                Console.Write(a[i]+",");
            }
        }
    }
}
