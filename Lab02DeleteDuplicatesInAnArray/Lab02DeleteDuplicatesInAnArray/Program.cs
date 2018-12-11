using System;
using System.Collections;

namespace Lab02DeleteDuplicatesInAnArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] duplicates = new int[] { 1, 1, 1, 1, 1, 1, 1, 2, 3, 4, 5, 6, 7, 7, 7, 5, 6, 8, 8, 9, 10 };
            int[] noDuplicates = DeleteDuplicates(duplicates);
            Console.WriteLine("Array with duplicates: ");
            PrintAnArray(duplicates);
            Console.WriteLine("Array with duplicates removed: ");
            PrintAnArray(noDuplicates);
        }

        /// <summary>
        /// This is a method that removes duplicate values from an array.
        /// The complexity for both Time and Space is O(n).
        /// NOTE: The return for this will not have the values in the same order even if there are no duplicates.
        /// </summary>
        /// <param name="array">The array to remove duplicates from</param>
        /// <returns>An array with no only unique values from the original array</returns>
        public static int[] DeleteDuplicates(int[] array)
        {
            Hashtable hashtable = new Hashtable();
            foreach(int ele in array)
            {
                // Microsoft's Hashtable built in method ContainsKey() is an O(1) operation
                if(!hashtable.ContainsKey(ele))
                {
                    hashtable.Add(ele, 1);
                }
                else
                {
                    hashtable[ele] = (int)hashtable[ele] + 1;
                }
            }
            // Everything after this point is just converting what we have in the hashtable back into an array.
            // This in itself is an O(n) operation in both Time and Space.

            // The property for Hashtables .Keys is an O(1) operation
            ICollection keys = hashtable.Keys;
            int[] newArray = new int[keys.Count];
            // This counter is necessary since ICollection doesn't allow for indexing, aka keys[i] doesn't work.
            int count = 0;
            foreach(var key in keys)
            {
                newArray[count] = (int)key;
                count++;
            }
            return newArray;
        }

        /// <summary>
        /// All this function does is iterate through the array and prints out each value.
        /// </summary>
        /// <param name="array"></param>
        public static void PrintAnArray(int[] array)
        {
            foreach (int value in array)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
    }
}
