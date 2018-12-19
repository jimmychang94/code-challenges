using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05StacksAndQueues.Classes.Palindrome
{
    public class CharNode
    {
        public char Value { get; set; }
        public CharNode Next { get; set; }

        public CharNode(char value)
        {
            Value = value;
        }
    }
}
