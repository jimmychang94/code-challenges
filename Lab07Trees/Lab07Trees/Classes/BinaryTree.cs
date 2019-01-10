using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07Trees.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public void Add(int value)
        {
            if (Root != null) Root.Add(value);
            else Root = new Node(value);
        }

        public void BreadthFirst(Action<int> callback)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);
            while (queue.Count > 0)
            {
                Node temp = queue.Dequeue();
                callback(temp.Value);
                if (temp.Left != null) queue.Enqueue(temp.Left);
                if (temp.Right != null) queue.Enqueue(temp.Right);
            }
        }

        public static Node CreateBST(int[] array)
        {
            BinaryTree BST = new BinaryTree();
            int left = 0;
            int right = array.Length;
            int mid = (left + right) / 2;
            BST.Root = new Node(array[mid]);
            BST.Root.CreateBST(array, left, mid);
            BST.Root.CreateBST(array, mid + 1, right);
            return BST.Root;
        }
    }
}
