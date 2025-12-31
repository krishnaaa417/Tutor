using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DataTypes.CopilotCodeProblems
{
    internal class AreaOfRectangle
    {
        static void Main(string[] args)
        {
            int length = 22;
            int width = 2;

            Console.WriteLine(AreaOfRectangles(length,width));
            Console.WriteLine(EvenOrOdd(length));
            Console.WriteLine(ComparisonOperatiors(length));
            Console.WriteLine(TernaryOps(length));
        }

        private static int AreaOfRectangles(int length,int width)
        {
            return length * width;
        }

        private static bool EvenOrOdd(int length)
        {
            if (length % 2 == 0) return true;
            else return false;
        }

        private static bool ComparisonOperatiors(int length)
        {
            if(length > 10 && length < 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int TernaryOps(int length)
        {
            int result = length > 10 ? 1 : 0;
            return result;
        }
    }
}
