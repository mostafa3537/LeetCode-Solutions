namespace Problems;

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using Problems.BinaryTree;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{

    public class LRUCache
    {
        public class Key
        {
            public int Value { get; set; }
            public int keyValue { get; set; }

            public Key(int value, int keyValue)
            {
                Value = value;
                this.keyValue = keyValue;
            }
        }
        private int _capacity;

        private Dictionary<int, LinkedListNode<Key>> _cache = new Dictionary<int, LinkedListNode<Key>>();

        private LinkedList<Key> _usageOrder = new LinkedList<Key>();

        public LRUCache(int capacity)
        {
            _capacity = capacity;
        }

        public int Get(int key)
        {
            if (_cache.TryGetValue(key, out LinkedListNode<Key>? node))
            {
                // Update the usage order
                _usageOrder.Remove(node);
                _usageOrder.AddLast(node);

                return node.Value.Value;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (_cache.TryGetValue(key, out LinkedListNode<Key>? node))
            {
                node.Value.Value = value;

                // Update the usage order
                _usageOrder.Remove(node);
                _usageOrder.AddLast(node);

                return;
            }
            else // New key
            {
                var keyObj = new Key(value, key);
                var newNode = new LinkedListNode<Key>(keyObj);

                if (_capacity >= _cache.Count) // Still have space adding new key
                {
                    _cache.Add(key, newNode);
                    _usageOrder.AddLast(newNode);

                }
                else // Cache is full, need to remove least used key before adding new key
                {
                    RemoveLeastUsed();
                    _cache.Add(key, newNode);
                    _usageOrder.AddLast(newNode);

                }
            }
        }

        private void RemoveLeastUsed()
        {
            var leastUsedNode = _usageOrder.First;
            if (leastUsedNode != null)
            {
                _cache.Remove(leastUsedNode.Value.keyValue);
                _usageOrder.RemoveFirst();
            }
        }
    }
    static void Main(string[] args)
    {
        var nums = 38;

        //var res = SortedArrayToBST(nums);
        Console.WriteLine();
    }
}
