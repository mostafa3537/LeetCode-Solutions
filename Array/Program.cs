namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
{
    public static bool HasCycle(ListNode head)
    {
        if (head == null)
        {
            return false;
        }

        // loop over stor the visited nodes in a hashset, if we see a node that is already in the hashset, then we have a cycle

        var result = false;
        HashSet<ListNode> visited = new HashSet<ListNode>();

        ListNode current = head;

        while (current != null)
        {
            if (visited.Contains(current))
            {
                result = true;
                break;
            }
            visited.Add(current);
            current = current.next;
        }

        return result;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

    }

    static void Main(string[] args)
    {
        //[3,2,0,-4]
        ListNode head = new ListNode(3);
        head.next = new ListNode(2);
        head.next.next = new ListNode(0);
        head.next.next.next = new ListNode(-4);
        head.next.next.next.next = new ListNode(2);

        var res = HasCycle(head);

        Console.WriteLine(res);
    }
}
