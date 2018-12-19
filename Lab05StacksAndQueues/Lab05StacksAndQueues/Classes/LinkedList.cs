using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05StacksAndQueues.Classes
{
    public class LinkedList
    {
        public Node Head { get; set; }

        /// <summary>
        /// This method adds a node to the head of the linked list.
        /// </summary>
        /// <param name="value"></param>
        public virtual void Add(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }

        /// <summary>
        /// THis method traverses the linked list and performs an action.
        /// </summary>
        /// <param name="action"></param>
        public void Traverse(Action<int> action)
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
        public void Insert(int value, int index)
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

        /// <summary>
        /// This method partitions the linked list into even and odd sections
        /// This partition has the evens first then the odds.
        /// </summary>
        public void Partition()
        {
            Node current = Head;
            while (current.Next != null)
            {
                Node temp = current.Next;
                if (current.Next.Value % 2 == 0)
                {
                    current.Next = current.Next.Next;
                    temp.Next = Head;
                    Head = temp;
                }
                else
                {
                    current = current.Next;
                }
            }

        }

        /// <summary>
        /// A method to remove a node from the linked list
        /// </summary>
        /// <param name="value"></param>
        public void Remove(int value)
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
    }
}
