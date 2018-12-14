using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06HashTables.Classes
{
    public class Node
    {
        public Dictionary<string, int> Value { get; set; }
        public Node Next { get; set; }

        public Node(Dictionary<string, int> value)
        {
            Value = value;
        }
    }
}
