using Lab07Trees.Classes;
using System;
using System.Collections.Generic;

namespace Lab07Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestBSTVerification();
            TestCreateBST();
        }

        static void TestCreateBST()
        {
            int[] testArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Node root = BinaryTree.CreateBST(testArray);
            BinaryTree bt = new BinaryTree();
            bt.Root = root;
            bt.BreadthFirst(Console.WriteLine);
        }

        static void TestBSTVerification()
        {
            Node root = new Node(10);
            root.Left = new Node(5);
            root.Right = new Node(15);
            root.Left.Left = new Node(1);
            root.Left.Right = new Node(7);
            root.Right.Left = new Node(12);
            root.Right.Right = new Node(21);

            bool test = BSTVerification(root);

            Console.WriteLine(test);
        }

        static bool BSTVerification(Node root)
        {
            List<int> list = new List<int>();
            root.InOrder(list.Add);
            bool value = true;
            for(int i = 0; i < list.Count - 1; i ++)
            {
                if (list[i] > list[i + 1])
                {
                    value = false;
                }
            }
            return value;
        }
    }
}
