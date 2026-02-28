namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
{
    public static ListNode DetectCycle(ListNode head)
    {
        if (head == null)
        {
            return null;
        }

        var intersection = GetIntersection(head);

        if (intersection == null)
        {
            return null;
        }

        while (intersection != head)
        {
            head = head.next;
            intersection = intersection.next;
 
        }

        return head;
    }

    private static ListNode GetIntersection(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (fast == slow)
            {
                return fast;
            }
        }

        return null;
    }

    public class ListNode(int x)
    {
        public int val = x;
        public ListNode next = null;
    }
    static void Main(string[] args)
    {
        //[3,2,0,-4]
        ListNode head = new ListNode(3);

        var cy = head.next = new ListNode(2);

        head.next.next = new ListNode(0);
        head.next.next.next = new ListNode(-4);
        head.next.next.next.next = cy;

        var res = DetectCycle(head);

        Console.WriteLine(res);
    }
}
