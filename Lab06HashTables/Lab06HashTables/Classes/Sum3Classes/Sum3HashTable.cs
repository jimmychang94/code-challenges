using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06HashTables.Classes.Sum3Classes
{
    public class Sum3HashTable
    {
        public int BucketSize { get; set; }
        public Sum3LinkedList[] Buckets { get; set; }

        public Sum3HashTable(int size)
        {
            BucketSize = size;
            Buckets = new Sum3LinkedList[BucketSize];
            for (int i = 0; i < BucketSize; i++)
            {
                Buckets[i] = new Sum3LinkedList();
            }
        }

        public int FindHash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash += key[i];
            }

            return hash;
        }

        public Sum3LinkedList GetBucket(string key)
        {
            int index = FindHash(key) % BucketSize;
            return Buckets[index];
        }

        public void Set(int key, int[] value)
        {
            Dictionary<int, int[]> obj = new Dictionary<int, int[]>();
            obj.Add(key, value);
            GetBucket(key.ToString()).Traverse(o =>
            {
                if (o.ContainsKey(key))
                {
                    o[key] = value;
                    obj = null;
                }
            });
            if (obj != null)
            {
                GetBucket(key.ToString()).Add(obj);
            }
        }

        public int[] Get(int key)
        {
            int[] init = new int[] { -999, -999 };
            int[] value = init;
            GetBucket(key.ToString()).Traverse(val =>
            {
                if (val.ContainsKey(key))
                {
                    value = val[key];
                }
            });
            if (value == init)
            {
                throw new Exception();
            }
            return value;
        }
    }
}
