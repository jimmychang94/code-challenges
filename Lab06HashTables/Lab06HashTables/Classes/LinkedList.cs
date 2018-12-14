using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06HashTables.Classes
{
    public class LinkedList
    {
        public Node Head { get; set; }

        /// <summary>
        /// This method adds a node to the head of the linked list.
        /// </summary>
        /// <param name="value"></param>
        public void Add(Dictionary<string, int> value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }

        /// <summary>
        /// THis method traverses the linked list and performs an action.
        /// </summary>
        /// <param name="action"></param>
        public void Traverse(Action<Dictionary<string, int>> action)
        {
            Node current = Head;
            while (current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }

        /// <summary>
        /// An insertion method that adds a node anywhere on the linked list
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        public void Insert(Dictionary<string, int> value, int index)
        {
            Node current = Head;
            Node node = new Node(value);
            while (index > 1 || current.Next != null)
            {
                current = current.Next;
                index--;
            }
            node.Next = current.Next;
            current.Next = node;
        }

        ///// <summary>
        ///// This method partitions the linked list into even and odd sections
        ///// This partition has the evens first then the odds.
        ///// </summary>
        //public void Partition()
        //{
        //    Node current = Head;
        //    while (current.Next != null)
        //    {
        //        Node temp = current.Next;
        //        if (current.Next.Value % 2 == 0)
        //        {
        //            current.Next = current.Next.Next;
        //            temp.Next = Head;
        //            Head = temp;
        //        }
        //        else
        //        {
        //            current = current.Next;
        //        }
        //    }
        //}

        /// <summary>
        /// A method to remove a node from the linked list
        /// </summary>
        /// <param name="value"></param>
        public void Remove(Dictionary<string, int> value)
        {
            Node current = Head;

            if (value == current.Value)
            {
                Head = current.Next;
            }
            while (current.Next.Next != null)
            {
                if (value == current.Next.Value)
                {
                    current.Next = current.Next.Next;
                }
            }
        }

        /// <summary>
        /// This method finds the value of the Kth node from the end of the linked list
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public Dictionary<string, int> KthLast(int k)
        {
            Node current = Head;
            Node runner = Head;
            while (k > 0)
            {
                runner = runner.Next;
                k--;
            }
            while (runner.Next != null)
            {
                runner = runner.Next;
                current = current.Next;
            }
            return current.Value;
        }

        /// <summary>
        /// An iterative method to find the middle value of the linked list
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> FindTheMiddle()
        {
            Node current = Head;
            Node runner = Head;
            while (runner != null && runner.Next != null)
            {
                runner = runner.Next.Next;
                current = current.Next;
            }
            return current.Value;
        }

        /// <summary>
        /// A recursive method to find the middle value of the linked list.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="runner"></param>
        /// <returns></returns>
        public Dictionary<string, int> FindTheMiddle(Node current, Node runner)
        {
            if (runner.Next == null || runner == null)
            {
                return current.Value;
            }
            return FindTheMiddle(current.Next, runner.Next.Next);
        }

        /// <summary>
        /// This method reverses the linked list
        /// </summary>
        public void Reverse()
        {
            Node current = Head;
            Node runner = current.Next;
            current.Next = null;
            if (runner == null)
            {
                return;
            }
            while (runner.Next != null)
            {
                Node temp = runner.Next;
                runner.Next = current;
                current = runner;
                runner = temp;
            }
            runner.Next = current;
            Head = runner;
        }
    }
}
