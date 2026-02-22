namespace Problems;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    public static ListNode MiddleNode(ListNode head)
    {
        var slow = head;
        var fast = head;

        while (fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
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


        var res = MiddleNode(head);

        Console.WriteLine(res);
    }
}
