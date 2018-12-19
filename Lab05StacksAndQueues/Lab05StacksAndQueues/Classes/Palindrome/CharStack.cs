using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05StacksAndQueues.Classes.Palindrome
{
    public class CharStack
    {
        public CharLinkedList Store { get; set; }

        public CharStack(CharLinkedList linkedList)
        {
            Store = linkedList;
        }

        public void Push(char value)
        {
            Store.Add(value);
        }

        public char Pop()
        {
            CharNode node = Store.Head;
            Store.Head = node.Next;
            return node.Value;
        }

        public char Peek()
        {
            return Store.Head.Value;
        }

        public bool IsEmpty()
        {
            return Store.Head == null;
        }
    }
}
