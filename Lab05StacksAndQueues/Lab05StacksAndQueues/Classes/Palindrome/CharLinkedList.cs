using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05StacksAndQueues.Classes.Palindrome
{
    public class CharLinkedList
    {
        public CharNode Head { get; set; }

        public void Add(char value)
        {
            CharNode node = new CharNode(value);
            if(Head == null)
            {
                Head = node;
                return;
            }
            node.Next = Head;
            Head = node;
        }
    }
}
