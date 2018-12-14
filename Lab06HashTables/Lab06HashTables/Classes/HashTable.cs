using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06HashTables.Classes
{
    public class HashTable
    {
        public int BucketSize { get; set; }
        public LinkedList[] Buckets { get; set; }

        public HashTable(int size)
        {
            BucketSize = size;
            Buckets = new LinkedList[BucketSize];
            for (int i = 0; i < BucketSize; i++)
            {
                Buckets[i] = new LinkedList();
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

        public LinkedList GetBucket(string key)
        {
            int index = FindHash(key) % BucketSize;
            return Buckets[index];
        }

        public void Set(string key, int value)
        {
            Dictionary<string, int> obj = new Dictionary<string, int>();
            obj.Add(key, value);
            GetBucket(key).Traverse(o =>
            {
                if (o.ContainsKey(key))
                {
                    o[key] += value;
                    obj = null;
                }
            });
            if (obj != null)
            {
                GetBucket(key).Add(obj);
            }
        }

        public int Get(string key)
        {
            int value = 0;
            GetBucket(key).Traverse(val =>
            {
                if (val.ContainsKey(key))
                {
                    value = val[key];
                }
            });
            return value;
        }
    }
}
