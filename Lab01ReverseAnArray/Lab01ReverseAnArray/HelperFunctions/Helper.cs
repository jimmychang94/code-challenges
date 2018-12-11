using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01ReverseAnArray.HelperFunctions
{
    public class Helper
    {
        /// <summary>
        /// This helper function swaps the two values in an array using the two pointers, i and j.
        /// i is the left value while j is the right value.
        /// This function transmutes the original array so there is no return value
        /// </summary>
        /// <param name="array">The array with values to be swapped</param>
        /// <param name="i">The index of the left value to be swapped</param>
        /// <param name="j">The index of the right value to be swapped</param>
        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        /// <summary>
        /// All this function does is iterate through the array and prints out each value.
        /// </summary>
        /// <param name="array"></param>
        public static void PrintAnArray(int[] array)
        {
            foreach(int value in array)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
    }
}
