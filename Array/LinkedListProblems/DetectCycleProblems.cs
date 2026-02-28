using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LinkedListProblems
{
    internal class DetectCycleProblems
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
    }
}
