using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Stacks
{
    internal class ValidParenthsis
    {
        static void Main(string[] args)
        {
            string s = "()[]";
            Console.WriteLine("Valid-Parenthsis.."+OptimizedApproach(s));
        }

        private static bool BruteForceApproach(String s)
        {
            while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
            {
               s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }

            return s.Length == 0;
            
        }

        private static bool OptimizedApproach(string s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
               char c = s[i];

                if (c == ')' && stack.Count > 0 && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (c == ']' && stack.Count > 0 && stack.Peek() == '[')
                {
                    stack.Pop();
                }
              else  if (c == '}' && stack.Count > 0 && stack.Peek() == '{')
                {
                    stack.Pop();
                }
               else  if (c == ']' && stack.Count > 0 && stack.Peek() == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    return false;
                }

            }

            return stack.Count == 0;
        }
    }
}
