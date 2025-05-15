using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Leetcode
{
    internal class ReverseThePrefixWord
    {
        static void Main(string[] args)
        {
            string word = "abcdefd";
            char ch = 'd';
            
           
            Console.WriteLine(ReversePrefix(word,ch));
        }

        //public  static string ReversePrefix(string word, char ch)
        //{
        //    char[] a = word.ToCharArray();
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] == ch)
        //        {
        //            for (int j = 0; j <= i / 2; j++)
        //            {
        //                char temp = a[j];
        //                a[j] = a[i - j];
        //                a[i - j] = temp;
        //            }
        //            return new string(a);
        //        }
        //    }

        //    return word;
        //}
    }
}
