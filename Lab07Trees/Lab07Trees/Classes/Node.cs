using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07Trees.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value)
        {
            Value = value;
        }

        public void Add(int value)
        {
            if(value < Value)
            {
                if (Left != null) Left.Add(value);
                else Left = new Node(value);
            }
            else
            {
                if (Right != null) Right.Add(value);
                else Right = new Node(value);
            }
        }

        public void Find(int value, Action<int> callback)
        {
            if (value == Value)
            {
                callback(Value);
            }
            if (value < Value)
            {
                if (Left != null) Left.Find(value, callback);
            }
            else
            {
                if (Right != null) Right.Find(value, callback);
            }
        }

        public void PostOrder(Action<int> callback)
        {
            if (Left != null) Left.PostOrder(callback);
            if (Right != null) Right.PostOrder(callback);
            callback(Value);
        }

        public void PreOrder(Action<int> callback)
        {
            callback(Value);
            if (Left != null) Left.PreOrder(callback);
            if (Right != null) Right.PreOrder(callback);
        }

        public void InOrder(Action<int> callback)
        {
            if (Left != null) Left.InOrder(callback);
            callback(Value);
            if (Right != null) Right.InOrder(callback);
        }

        public void CreateBST(int[] array, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            int mid = (left + right) / 2;
            if (array[mid] < Value)
            {
                Left = new Node(array[mid]);
                Left.CreateBST(array, left, mid);
                Left.CreateBST(array, mid + 1, right);
            }
            if (array[mid] > Value)
            {
                Right = new Node(array[mid]);
                Right.CreateBST(array, left, mid);
                Right.CreateBST(array, mid + 1, right);
            }
        }
    }
}
