using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tutor.LinkedList
{
    internal class Evaluate
    {

        static void PrintLinkedList(Nodes head)
        {
            Nodes current = head;

            while (current != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }
        }

        static void Main(string[] args)
        {
            Nodes n1 = new Nodes(1);
            Nodes n2 = new Nodes(2);
            Nodes n3 = new Nodes(3);
            Nodes n4 = new Nodes(4);
            Nodes n5 = new Nodes(5);

            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            Nodes head = n1;

            PrintLinkedList(head);

            
            
        }
    }

    public class Nodes {
       public int val;
       public Nodes next;

        public Nodes(int value)
        {
            val = value;
            next = null;
            
        }
    }


}
