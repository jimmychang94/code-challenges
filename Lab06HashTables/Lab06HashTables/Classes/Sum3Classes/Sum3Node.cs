using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06HashTables.Classes.Sum3Classes
{
    public class Sum3Node
    {
        public Dictionary<int, int[]> Value { get; set; }
        public Sum3Node Next { get; set; }

        public Sum3Node(Dictionary<int, int[]> value)
        {
            Value = value;
        }
    }
}
