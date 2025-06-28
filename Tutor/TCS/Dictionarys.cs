using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TCS
{
    internal class Dictionarys
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "Nallapothula");
            dict.Add(2, "Venkata");
            dict.Add(3, "Krishna");
            dict.Add(4, "Prasad");

            Console.WriteLine(dict.Count);
            Console.WriteLine(dict.ContainsKey(3));

            foreach (var result in dict)
            {
                Console.WriteLine(result);
            }

            dict[1] = "love";

            Console.WriteLine("--");
            foreach (var result in dict)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("---");

            if (dict.ContainsKey(4))
            {
                Console.WriteLine("elses");
            }


        }
    }
}
