using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DAY1
{
    internal class OccurenceOfEachCharacter
    {
        static void Main(string[] args)
        {
            string s = "hello";
             BruteForceApproach(s);
        }

        private static void BruteForceApproach(string s)
        {
            //char[] n = s.ToCharArray();
            //int counts = 0;
            //for (int i = 0; i < n.Length; i++)
            //{
            //    int count = 1;
            //    for (int j = i+1; j < n.Length; j++)
            //    {
            //        if (n[i] == n[j])
            //        {
            //            count++;
            //        }

            //        counts = count;
            //    }
            //}
            //return counts;

            char[] chars = s.ToCharArray();
            bool[] visited = new bool[chars.Length];

            for (int i = 0; i < chars.Length; i++)
            {
                if (visited[i])
                    continue;

                int count = 1;

                for (int j = i + 1; j < chars.Length; j++)
                {
                    if (chars[i] == chars[j])
                    {
                        count++;
                        visited[j] = true;
                    }
                }

                Console.WriteLine($"{chars[i]} = {count}");

            }
        }
    }
}


