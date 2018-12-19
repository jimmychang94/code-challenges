using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05StacksAndQueues.Classes
{
    public class Queue
    {
        public QueueLinkedList Store { get; set; }

        public Queue(QueueLinkedList linkedList)
        {
            Store = linkedList;
        }

        public void Enqueue(int value)
        {
            Store.Add(value);
        }

        public int Dequeue()
        {
            Node node = Store.Head;
            Store.Head = node.Next;
            return node.Value;
        }

        public int Peek()
        {
            return Store.Head.Value;
        }

        public bool IsEmpty()
        {
            return Store.Head == null;
        }
    }
}
