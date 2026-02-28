namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {

        if (list1 == null)
        {
            return list2;
        }
        if (list2 == null)
        {
            return list1;
        }
        ListNode dummy = new ListNode(0);
        ListNode head = dummy;

        var current1 = list1;
        var current2 = list2;

        while (current1 != null && current2 != null)
        {
            if (current1.val <= current2.val)
            {
                head.next = new ListNode(current1.val);
                current1 = current1.next;


            }
            else
            {
                head.next = new ListNode(current2.val);
                current2 = current2.next;

            }
            head = head.next;
        }

        while (current1 != null)
        {

            head.next = new ListNode(current1.val);
            head = head.next;
            current1 = current1.next;

        }

        while (current1 != null)
        {
            head.next = new ListNode(current2.val);
            head = head.next;
            current2 = current2.next;
        }

        return dummy.next;
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
        //list1 = [1,2,4], list2 = [1,3,4]
        ListNode list1 = new ListNode(1);
        list1.next = new ListNode(2);
        list1.next.next = new ListNode(4);

        var list2 = new ListNode(1);
        list2.next = new ListNode(3);
        list2.next.next = new ListNode(4);

        var res = MergeTwoLists(list1, list2);

        Console.WriteLine(res);
    }
}
