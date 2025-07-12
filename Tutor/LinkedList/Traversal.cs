using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.LinkedList
{
    internal class Traversal
    {
        static void Main(string[] args)
        {
            ListNode1 head = new ListNode1(10);
            head.next = new ListNode1(20);
            head.next.next = new ListNode1(30);
            head.next.next.next = new ListNode1(40);

            PrintConnections(head);
        }

        static void PrintConnections(ListNode1 head)
        {
            int index = 1;

            while (head != null)
            {
                Console.WriteLine($"Node {index}: val = {head.val}, next = {(head.next != null ? head.next.val.ToString() : "null")}");
                head = head.next;
                index++;
            }
            Console.WriteLine("----");
            while (head.next != null)
            {
                Console.WriteLine($"Node {index}: val = {head.val}, next = {(head.next != null ? head.next.val.ToString() : "null")}");
                head = head.next;
                index++;
            }
        }
    }

    internal class ListNode1
    {
        public int val;
        public ListNode1 next;
        public ListNode1(int value)
        {
            val=value;
            next = null;
        }

       
       
    }
}
