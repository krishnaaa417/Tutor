using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.TCS
{
    internal class BaseBallGame
    {
        static void Main(string[] args)
        {
            string[] s = { "5", "2", "C", "D", "+" };
            Console.WriteLine(OptimizedApproach(s));

        }

        private static int BruteForceApproach(string[] s)
        {
            int n = s.Length;
            // + = sum of previous two scores;
            // d = double of previous one
            //c = remove the one
            // finally return sum of all fucking numbers

            

            return s.Length;
        }

        private static int OptimizedApproach(string[] s)
        {
            int n = s.Length;
            Stack<int> stack = new Stack<int>();

            foreach (var result in s)
            {
                if (result == "C")
                {
                    stack.Pop();
                }
                else if (result == "D")
                {
                    stack.Push(stack.Peek() * 2);
                }
                else if(result == "+")
                {
                     int top1 = stack.Pop();
                    int top2 = stack.Peek();
                    int sum = top1 + top2;
                    stack.Push(top1);
                    stack.Push(sum);
                }
                else
                {
                    stack.Push(int.Parse(result));
                }
            }
            return stack.Sum();
        }
    }
}
