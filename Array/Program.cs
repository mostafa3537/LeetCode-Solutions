namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    public class AllOne
    {

        public class Node
        {
            public HashSet<string> Keys { get; set; }
            public int Count { get; set; }
            public Node Prev { get; set; }
            public Node Next { get; set; }
            public Node(int count)
            {
                Count = count;
                Keys = new HashSet<string>();
            }
        }

        private Dictionary<string, Node> keyCount;

        private Node head;
        private Node tail;

        private string maxKey;
        private string minkey;
        public AllOne()
        {
            keyCount = new Dictionary<string, Node>();
            minkey = string.Empty;
            maxKey = string.Empty;

            head = new Node(0);
            tail = new Node(0);

            head.Next = tail;
            tail.Prev = head;
        }

        public void Inc(string key)
        {
            // if key is not present, add it to the head node
            // if key is present, move it to the next node

            if (!keyCount.ContainsKey(key))
            {
                var node = head.Next;

                if (node == tail || node.Count != 1)
                {
                    // insert new node with count 1 after head

                    var newNode = new Node(1);
                    node = InsertAfter(head, newNode);
                }
                node.Keys.Add(key);
                keyCount[key] = node;
            }
            else
            {
                // find the node with the key remove the key from the node and add it to the next node

                var currentNode = keyCount[key];
                var nextNode = currentNode.Next;

                if (currentNode == tail || nextNode.Count != currentNode.Count + 1)
                {
                    // insert new node with count 1 after head
                    nextNode = InsertAfter(currentNode, new Node(currentNode.Count + 1));
                }

                nextNode.Keys.Add(key);
                keyCount[key] = nextNode;

                RemoveKey(currentNode, key);
            }

        }

        private void RemoveKey(Node currentNode, string key)
        {
            currentNode.Keys.Remove(key);
            if (currentNode.Keys.Count == 0)
            {
                // remove the node from the list
                currentNode.Prev.Next = currentNode.Next;
                currentNode.Next.Prev = currentNode.Prev;
            }
        }

        private Node InsertAfter(Node head, Node newNode)
        {
            // insert newNode after head

            newNode.Prev = head;

            newNode.Next = head.Next;

            head.Next.Prev = newNode;

            head.Next = newNode;
            return newNode;
        }

        public void Dec(string key)
        {
            if (keyCount.ContainsKey(key))
            {
                // find the node with the key remove the key from the node  
                var currentNode = keyCount[key];
                var prevNode = currentNode.Prev;

                if (currentNode.Count == 1)
                {
                    RemoveKey(currentNode, key);
                    keyCount.Remove(key);
                    return;
                }

                if (currentNode == head || prevNode.Count != currentNode.Count - 1)
                {
                    // insert new node with count 1 after head
                    prevNode = InsertAfter(currentNode.Prev, new Node(currentNode.Count - 1));
                }
                prevNode.Keys.Add(key);
                keyCount[key] = prevNode;
                RemoveKey(currentNode, key);
            }
    
        }

        public string GetMaxKey()
        {
            return tail.Prev.Keys.FirstOrDefault() ?? "";
        }

        public string GetMinKey()
        {
            return head.Next.Keys.FirstOrDefault() ?? "";
        }
    }
    static void Main(string[] args)
    {
        AllOne allOne = new AllOne();
        allOne.Inc("hello");
        allOne.Inc("hello");
        allOne.GetMaxKey(); // return "hello"
        allOne.GetMinKey(); // return "hello"
        allOne.Inc("leet");
        allOne.GetMaxKey(); // return "hello"
        allOne.GetMinKey(); // return "leet"

        Console.WriteLine();
    }
}
