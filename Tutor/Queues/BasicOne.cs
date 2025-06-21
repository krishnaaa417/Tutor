using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Queues
{
    internal class BasicOne
    {
        static void Main(string[] args)
        {
           Queue<String> queue = new Queue<String>();

            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Enqueue("d");

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Count());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            
        }
    }
}
