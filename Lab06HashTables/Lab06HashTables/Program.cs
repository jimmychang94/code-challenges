using Lab06HashTables.Classes;
using Lab06HashTables.Classes.Sum3Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Lab06HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSum3();
        }

        static void TestSum3()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -4 };
            int[] result = Sum3HashVersion(array);
            foreach(int val in result)
            {
                Console.Write($"{val} ");
            }
            Console.WriteLine();
        }

        static void TestHash()
        {
            string[] words = File.ReadAllLines("../../../Data/Data.txt");
            HashTable hashTable = new HashTable(1000);
            var watch = Stopwatch.StartNew();
            foreach (string word in words)
            {
                hashTable.Set(word, word.Length);
            }
            watch.Stop();
            Console.WriteLine($"Time passed setting all words: {watch.Elapsed}");
            watch.Reset();
            watch.Start();
            foreach (string word in words)
            {
                hashTable.Get(word);
            }
            watch.Stop();
            Console.WriteLine($"Time passed getting all words: {watch.Elapsed}");
        }

        static int[] Sum3HashVersion(int[] array)
        {
            Sum3HashTable hashTable = new Sum3HashTable(array.Length);
            for(int i = 0; i < array.Length - 1; i ++)
            {
                for(int j = i + 1; j < array.Length; j ++)
                {
                    int key = -(array[i] + array[j]);
                    int[] value = new int[] { array[i], array[j] };
                    hashTable.Set(key, value);
                }
            }
            for(int i = 0; i < array.Length; i ++)
            {
                try
                {
                    int[] value = hashTable.Get(array[i]);
                    int[] result = new int[] { value[0], value[1], array[i] };
                    return result;
                }
                catch (Exception)
                {
                    
                }
            }
            return new int[] { -1, -1, -1 };
        }
    }
}
