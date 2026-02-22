namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
{
    public static ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        int length = GetLength(head);

        // If we need to remove the head
        if (length == n)
            return head.next;

        var indexToBeRemoved = length - n-1;

        Remove(head, indexToBeRemoved);

        return head;
    }

    private static void Remove(ListNode head, int indexToBeRemoved)
    {
        var index = 0;

        ListNode current = head;

        while (current.next != null && index != indexToBeRemoved)
        {
            current = current.next;
            index++;
        }

        if (current.next != null)
        {
            current.next = current.next.next;
        }
    }
    public static int  GetLength(ListNode head)
    {
        int length = 0;
        ListNode current = head;
        while (current != null)
        {
            length++;
            current = current.next;
        }
        return length;
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
        //1,2,3,4,5
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(5);

        var n = 2;

        var res = RemoveNthFromEnd(head, n);

        Console.WriteLine(res);
    }
}
