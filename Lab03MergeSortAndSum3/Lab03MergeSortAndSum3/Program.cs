using System;

namespace Lab03MergeSortAndSum3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //TestMergeSort();
            TestSumThree();
        }

        static void TestMergeSort()
        {
            int[] array = new int[] { 1, 5, 4, 2, 100, 294, 7, 75, 25, 46, 5, 300, -1 };
            array = MergeSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        static void TestSumThree()
        {
            int[] array = new int[] { 1, 2, 3, 4, -1, -2, -3 };
            int[] three = SumThree(array);
            for (int i = 0; i < three.Length; i++)
            {
                Console.Write($"{three[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// This method finds a set of 3 values that sum to 0.
        /// Currently it runs in O(n^3) Time complexity and O(1) Space complexity.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int[] SumThree(int[] array)
        {
            int[] triplet = new int[] { -1, -1, -1 };
            for(int i = 0; i < array.Length - 2; i ++)
            {
                for(int j = i + 1; j < array.Length - 1; j ++)
                {
                    for(int k = j + 1; k < array.Length; k ++)
                    {
                        if(array[i] + array[j] + array[k] == 0)
                        {
                            triplet[0] = array[i];
                            triplet[1] = array[j];
                            triplet[2] = array[k];
                        }
                    }
                }
            }
            return triplet;
        }



        /// <summary>
        /// This function recursively sorts the given array.
        /// It does not transmute the original array.
        /// Time complexity is O(n * log(n)) while space complexity is O(n).
        /// </summary>
        /// <param name="array">The original array</param>
        /// <returns>The sorted array</returns>
        static int[] MergeSort(int[] array)
        {
            // The base case which allows for the return of arrays of length 1.
            if(array.Length < 2)
            {
                return array;
            }
            int mid = array.Length / 2;
            // additional arrays are initialized to hold the left and right segments of the array.
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];
            // This is used to fill the left array with all the values up until the midpoint
            // Similarly, the right array is filled with all the values after the midpoint (and the midpoint itself)
            Array.Copy(array, 0, left, 0, mid);
            Array.Copy(array, mid, right, 0, array.Length - mid);
            return Merge(MergeSort(left), MergeSort(right));
        }

        /// <summary>
        /// This method iterates through the two arrays and appends onto a new array the smaller value.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        static int[] Merge(int[] left, int[] right)
        {
            int range = left.Length + right.Length;
            int j = 0, k = 0;
            int[] mergedArray = new int[range];
            for(int i = 0; i < range; i ++)
            {
                // These if statements check to see if one array is longer than the other
                // If it is, then we append the rest of the longer array onto the end of the new array
                if(k >= right.Length)
                {
                    Array.Copy(left, j, mergedArray, i, range - i);
                    return mergedArray;
                }
                else if (j >= left.Length)
                {
                    Array.Copy(right, k, mergedArray, i, range - i);
                    return mergedArray;
                }
                if (left[j] > right[k])
                {
                    mergedArray[i] = right[k];
                    k++;
                }
                else
                {
                    mergedArray[i] = left[j];
                    j++;
                }
            }
            return mergedArray;
        }
    }
}
