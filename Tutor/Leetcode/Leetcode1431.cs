using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Leetcode
{
    internal class Leetcode1431
    {
        static void Main(string[] args)
        {

            //string s = "Hello how are you Contestant";
            //int k = 4;

            //for (int i = 0; i < k; i++)
            //{
            //    if(s.)
            //}



          

















            // NewMethod();

            //string[] s1 = { "ab", "c" };
            //string[] s2 = { "a", "bc" };
            //bool isFalse = false;

            //for (int i = 0; i < s1.Length; i++)
            //{
            //  if(s1.Length != s2.Length)
            //    {
            //        Console.WriteLine(isFalse); ;
            //        break ;
            //    }
            //  else if(s1[i] != s2[i])
            //    {
            //        Console.WriteLine(isFalse);
            //        break ;
            //    }
            //}

            //isFalse = true;
            //Console.WriteLine(true);

        }

        private static void NewMethod()
        {
            int[] value = { 33, 242, 2332, 1, 2 };
            int max = int.MinValue;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] > max)
                {
                    max = value[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
