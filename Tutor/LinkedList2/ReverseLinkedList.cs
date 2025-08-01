using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.LinkedList2
{
    internal class ReverseLinkedList
    {
        static void Main(string[] args)
        {
           ListNode l1 = new ListNode(10);
            ListNode l2 = new ListNode(20);
            ListNode l3 = new ListNode(30);
            ListNode l4 = new ListNode(40);
            ListNode l5 = new ListNode(50);
            ListNode head = l1;
            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            Console.WriteLine("original list:");
            PrintList(l1);
            ListNode reversed = ReverseList(l1);

            Console.WriteLine("ReversedList..");
            PrintList(reversed);
        }

        public static ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;

            while (current != null)
            {
                ListNode nextnode = current.next;
                current.next = prev;
                prev = current;
                current = nextnode;
            }
            return prev;
        }
        public static void PrintList(ListNode head)
        {
            ListNode current = head;
            while (current != null)
            {
                Console.Write(current.value + " -> ");
                current = current.next;
            }
            Console.WriteLine("null");
        }
    }
    public class ListNode
    {
       public int value; //instance variable
       public ListNode next;

        public ListNode(int value=0,ListNode next = null)
        {
            this.value = value;
            this.next = next;
        }
    }
}
