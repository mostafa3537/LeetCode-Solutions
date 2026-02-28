using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LinkedListProblems
{
    internal class MergeTwoListsProblem
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
    }
}
