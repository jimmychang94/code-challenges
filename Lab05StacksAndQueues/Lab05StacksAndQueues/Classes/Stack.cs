using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05StacksAndQueues.Classes
{
    public class Stack
    {
        public LinkedList Store { get; set; }

        public Stack(LinkedList linkedList)
        {
            Store = linkedList;
        }

        public void Push(int value)
        {
            Store.Add(value);
        }

        public int Pop()
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

        public int StockSpan()
        {
            if (Store.Head == null)
            {
                return -1;
            }
            int counter = 0;
            int stock = Pop();
            while(Store.Head != null)
            {
                counter++;
                int compare = Pop();
                if(compare > stock)
                {
                    return counter;
                }
            }
            return counter;
        }
    }
}
