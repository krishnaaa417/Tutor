using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.LinkedList2
{
    internal class BasicOperations
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(10);
            Node n2 = new Node(20);
            Node n3 = new Node(30);
            Node n4 = new Node(40);

            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            Node head = n1;

          while (head != null)
            {

                Console.WriteLine(head.value);
                head = head.next;
               
            }
        }
    }


    public class Node
    {
        public int value;
        public Node next;

        public Node(int value)
        {
                this.value = value;
                this.next = null;
        }

    }
}
