using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastrucure
{
    public class LinkedList
    {

        public class Node
        {
            public Node next;
            public object value;

        }

        public Node Head;

        public Node Current;

        public int Count;

        public LinkedList()
        {
            Head = new Node();
            Current = Head; // Initially head and current will be same
            Count = 0;
        }

        public void AddAtLast(object data)
        {
            Node newNode = new Node
            {
                value = data
            };
            Current.next = newNode;
            Current = newNode;
            Count++;


        }

        public void AddAtStart(object data)
        {
            Node newNode = new Node
            {
                value = data
            };

            newNode.next = Head.next;
            Head.next = newNode;
            Count++;


        }

        public void RemoveFromStart()
        {
            if (Count > 0)
            {
                Head.next = Head.next.next;
                Count--;
            }
            else
            {
                Console.WriteLine("No element exist in this linked list.");
            }
        }

        public void PrintAllNodes()
        {
            //Traverse from head
            Console.Write("Head ->");
            Node curr = Head;
            while (curr.next != null)
            {
                curr = curr.next;
                Console.Write(curr.value);
                Console.Write("->");
            }
            Console.Write("NULL");
        }

        public void PrintMiddle()
        {
            Node slowpointer = Head;
            Node fastpointer = Head;
            if (Head!=null)
            {
                while (fastpointer!=null && fastpointer.next!=null)
                {
                    slowpointer = slowpointer.next;
                    fastpointer = fastpointer.next.next;
                }
                Console.WriteLine(slowpointer.value);

            }

        }

        static void Main(string[] args)
        {
            LinkedList lnklist = new LinkedList();
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.AddAtLast(12);
            lnklist.AddAtLast("John");
            lnklist.AddAtLast("Peter");
            lnklist.AddAtLast(34);
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.AddAtStart(55);
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.RemoveFromStart();
            lnklist.PrintAllNodes();
            lnklist.PrintMiddle();

            Console.ReadKey();
        }
    }
}
