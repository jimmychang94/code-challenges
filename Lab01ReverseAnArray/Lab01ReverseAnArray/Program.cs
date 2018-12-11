using Lab01ReverseAnArray.HelperFunctions;
using System;

namespace Lab01ReverseAnArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Original Array: ");
            Helper.PrintAnArray(array);
            //ReverseAnArrayIterative(array);
            ReverseAnArrayRecursive(array, 0);
            Console.WriteLine("Original Array after it got reversed: ");
            Helper.PrintAnArray(array);
        }

        /// <summary>
        /// This method reverses an array by swapping a left value with a corresponding right value.
        /// It goes through the array iteratively with a for loop.
        /// </summary>
        /// <param name="array">The array to be reversed</param>
        public static void ReverseAnArrayIterative(int[] array)
        {
            for(int i = 0; i < array.Length / 2; i ++)
            {
                // I assigned (array.Length - 1 - i) to a variable instead of using it directly since I will be using it multiple times
                // Additionally, this way is much easier for me to read
                int j = array.Length - 1 - i;

                // I separated out the swap method since I think this reads a lot cleaner.
                Helper.Swap(array, i, j);
            }
        }

        /// <summary>
        /// This method reverses an array by swapping a left value with a corresponding right value.
        /// It goes through the array recursively using i as a pointer to the current location in the array.
        /// </summary>
        /// <param name="array">The array to be reversed</param>
        /// <param name="i">The pointer to where in the array we are</param>
        public static void ReverseAnArrayRecursive(int[] array, int i)
        {
            // This is the base case to end the recursive calls.
            // The check: i == array.Length / 2 would work for arrays that have even number of values in it but not for an odd number.
            // Similarly, the check: i > array.Length / 2 only works for odd numbers so using >= accounts for both cases.
            if(i >= array.Length / 2)
            {
                return;
            }
            Helper.Swap(array, i, array.Length - 1 - i);
            
            // I could have used the prefix incrementor but I think that i + 1 is easier to understand.
            // Additionally it doesn't change i which doesn't happen with an incrementor.
            ReverseAnArrayRecursive(array, i + 1);
        }
    }
}
