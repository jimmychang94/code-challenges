using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05StacksAndQueues.Classes
{
    public class QueueLinkedList : LinkedList
    {
        public Node Tail { get; set; }

        public override void Add(int value)
        {
            Node node = new Node(value);
            if (Tail == null)
            {
                Tail = node;
                Head = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }

        }
    }
}
