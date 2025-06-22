using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Queues
{
    internal class StackUsingQueues
    {
      static  Queue<int> ints = new Queue<int>();
        static void Main(string[] args)
        {

            App(10);
            App(20);
            App(30);


            Console.WriteLine("Stack (simulated)");

            foreach (int item in ints)
            {
                Console.WriteLine(item);
            }

        }

        private static void App(int x)
        {
           // Queue<int> ints = new Queue<int>();
            ints.Enqueue(x);
           
            for (int i = 1; i < ints.Count; i++)
            {
                ints.Enqueue(ints.Dequeue());
            }

            ints.Peek();
            
        }

       
    }
}
