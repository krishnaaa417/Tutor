using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Strings
{
    internal class Leetcode1816
    {
        static void Main(string[] args)
        {
            int count = 0;
            string s = "Hello how are you Contestant ";
            int k = 4;
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == 32)
                {
                    count++;
                    if (count == k)
                    {
                        Console.WriteLine(s.Substring(0, i));
                        break;
                    }
                }
            }
            //Console.WriteLine(s);
           
        
            
        }
    }
}
