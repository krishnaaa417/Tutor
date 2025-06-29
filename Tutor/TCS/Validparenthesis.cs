using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TCS
{
    internal class Validparenthesis
    {
        static void Main(string[] args)
        {
            string s = "()[]{}";
            Console.WriteLine(IsValid(s));
        }

        private static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            int n = s.Length;
            
            for (int i = 0; i < n; i++)
            {
                char c = s[i];

                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' && stack.Count > 0 && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (c == ']' && stack.Count > 0 && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (c == '}' && stack.Count > 0 && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else { return false; }
            }

            return stack.Count == 0;
        }
    }
}
