using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.HashMap
{
    internal class Iterations
    {
        static void Main(string[] args)
        {
            Dictionary<String,int> dict = new Dictionary<String,int>();
            dict.Add("Mango", 1);
            dict.Add("Apple", 2);
            dict.Add("Lemon", 3);

            foreach (var dic in dict)
            {
                Console.WriteLine(dic.Key +","+dict.Values);
            }
        }
    }
}
