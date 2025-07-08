using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.LinkedList
{
    internal class Traverse
    {
        static void Main(string[] args)
        {
            Node node3 = new Node(30);
            Node node2 = new Node(20, node3);
            Node head = new Node(10, node2);
            TraverseList(head);
        }

        static void TraverseList(Node head)
        {
            while (head != null)
            {
                Console.WriteLine(head.val+",");
                head = head.next;
            }
            Console.WriteLine("null..");
        }
    }

    public class Node
    {
        public int val;
        public Node next;

        public Node(int value)
        {
            val = value;
        }
        public Node(int value,Node nexts)
        {
            val = value;
            next = nexts;
        }
    }
}
