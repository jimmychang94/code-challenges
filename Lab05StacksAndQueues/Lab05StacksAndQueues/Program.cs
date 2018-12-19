using Lab05StacksAndQueues.Classes;
using Lab05StacksAndQueues.Classes.Palindrome;
using System;
using System.Text;

namespace Lab05StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStockSpan();
        }
        
        static void TestStockSpan()
        {
            Stack stack = new Stack(new LinkedList());
            stack.Push(8);
            stack.Push(6);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(5);
            stack.Push(7);
            int value = stack.StockSpan();
            Console.WriteLine("With values of: 8 -> 6 -> 4 -> 3 -> 2 -> 5 -> 7");
            Console.WriteLine("The expected value is: 6");
            Console.WriteLine($"We get a value of: {value}");
        }

        static void TestPalindrome()
        {
            CharLinkedList test = new CharLinkedList();
            test.Add('a');
            test.Add('b');
            test.Add('b');
            test.Add('a');
            Console.WriteLine($"For characters 'a' 'b' 'b' 'a' IsPalindrome returns: {IsPalindrome(test)}");
            CharLinkedList test2 = new CharLinkedList();
            test2.Add('a');
            test2.Add('b');
            test2.Add('c');
            test2.Add('d');
            Console.WriteLine($"For characters 'a' 'b' 'c' 'd' IsPalindrome returns: {IsPalindrome(test2)}");
        }

        
        static bool IsPalindrome(CharLinkedList linkedList)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            CharStack stack = new CharStack(new CharLinkedList());
            CharNode current = linkedList.Head;
            while(current != null)
            {
                char value = current.Value;
                sb1.Append(value);
                stack.Push(value);
                current = current.Next;
            }
            while(!stack.IsEmpty())
            {
                sb2.Append(stack.Pop());
            }
            return sb1.ToString() == sb2.ToString();
        }
    }
}
