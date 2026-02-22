using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LinkedListProblems
{
    internal class RemoveNthFromEndProblem
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int length = GetLength(head);

            // If we need to remove the head
            if (length == n)
                return head.next;

            var indexToBeRemoved = length - n - 1;

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
        public static int GetLength(ListNode head)
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
    }
}
