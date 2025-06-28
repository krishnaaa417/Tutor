using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TCS
{
    internal class ReverseAnArray
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5};
            ReverseArray(arr);
        }

        private static void ReverseArray(int[] array)
        {
            int n = array.Length;

            for (int i = n-1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
