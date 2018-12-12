using Lab04LinkedLists.Classes;
using System;

namespace Lab04LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Partition();
            //list.Reverse();
            list.Traverse(Console.WriteLine);
            //Console.WriteLine(list.KthLast(3));
            //Console.WriteLine(list.FindTheMiddle(list.Head, list.Head));
        }
    }
}
