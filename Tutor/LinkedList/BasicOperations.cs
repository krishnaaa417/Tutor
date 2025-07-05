using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Tutor.Stacks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tutor.LinkedList
{
    internal class BasicOperations
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(6);
            head.next.next.next = new ListNode(3);
            head.next.next.next.next = new ListNode(6);

            Console.WriteLine("Original List:");
            PrintList(head);

            int valToRemove = 6;
           Solution solution = new Solution();
            ListNode newHead = solution.RemoveElements(head, valToRemove);

            Console.WriteLine("\nList After Removing " + valToRemove + ":");
            PrintList(newHead);
        }

        static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.WriteLine(node.val + "->");
                node = node.next;
            }
            Console.WriteLine("null");
        }

       public class Solution
        {
            public ListNode RemoveElements(ListNode head, int val)
            {
                ListNode list = new ListNode(0);
                list.next = head;

                ListNode dummy = list;

                while (dummy != null && dummy.next != null)
                {
                    if (dummy.next.val == val)
                    {
                        dummy.next = dummy.next.next;
                    }
                    else
                    {
                        dummy = dummy.next;
                    }
                }
                return dummy.next;

            }
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int value = 0, ListNode nextnode = null)
        {
            val = value;
            next = nextnode;
        }
    }
}
