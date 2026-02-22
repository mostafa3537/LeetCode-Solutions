using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LinkedListProblems
{
    internal class MiddleNodeProblem
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
    }
}
