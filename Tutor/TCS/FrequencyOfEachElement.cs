using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TCS
{
    internal class FrequencyOfEachElement
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 7, 2, 4, 8, 7, 4, 9, 2 };
            Dictionary<int, int> map = Frequency(arr);
            Console.WriteLine("frequencies");

            foreach (var entry in map)
            {
                Console.WriteLine("number."+entry.Key +",,"+entry.Value);
            }

        }

        private static Dictionary<int,int> Frequency(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (int number in nums)
            {
                if (map.ContainsKey(number))
                {
                    map[number]++;
                }
                else
                {
                    map.Add(number, 1);
                }
            }
            return map;
        }
    }
}
