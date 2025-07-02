using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Mind
{
    internal class First 
    {

        static void Main(string[] args)
        {

            IMathOperation m = new Calculator();

            int add = m.Add(5, 5);
            int sub = m.Subtract(5, 5);

            IAdvanceMathOperation a = new Calculator();
          int l =  a.Add(15, 15);
          int l1 =  a.Subtract(0, 5);


            Console.WriteLine(add+"Firstinterface");
            Console.WriteLine(sub+"Subtraction.");

            Console.WriteLine(l+"..add");
            Console.WriteLine(l1+"..sub");

        }

        

    }

    public interface IMathOperation
    {
        int Add(int a, int b);
        int Subtract(int a, int b);

    }

    public interface IAdvanceMathOperation
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
    }

    public class Calculator : IMathOperation , IAdvanceMathOperation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
           return b - a;
        }
    }
}

