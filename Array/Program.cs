namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
{
    public static ListNode Partition(ListNode head, int x)
    {
        if (head == null)
        {
            return null;
        }

        var leftList = new ListNode();
        var rightList = new ListNode();     
        
        var leftTail = leftList;
        var rightTail = rightList;

        ListNode current = head;

        while (current != null)
        {
            var nextNode = current.next;
            current.next = null;

            if (current.val < x)
            {
                leftTail.next = current;
                leftTail = current;
            }
            else
            {
                rightTail.next = current;
                rightTail = current;
            }


            current = nextNode;
        }

        leftTail.next = rightList.next;

        return leftList.next;
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
        //[1,4,3,2,5,2]
        ListNode head = new ListNode(1);
        head.next = new ListNode(4);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(2);
        head.next.next.next.next = new ListNode(5);
        head.next.next.next.next.next = new ListNode(2);

        var x = 3;
        var res = Partition(head, x);

        Console.WriteLine(res);
    }
}
