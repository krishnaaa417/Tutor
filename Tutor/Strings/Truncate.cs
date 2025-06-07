using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Strings
{
    internal class Truncate
    {
        static void Main(string[] args)
        {
            string s = "Hello how are you Contestant";
            int k = 4;
            Console.WriteLine(TruncateSentence(s,k));
        }

        public  static string TruncateSentence(string s, int k)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    count++;
                }
                else if(count == k)
                {
                    return s.Substring(0,i);
                }
              
            }

            return s;
        }

    }
}
