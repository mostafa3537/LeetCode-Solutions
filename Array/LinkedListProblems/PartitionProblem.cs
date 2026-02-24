using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LinkedListProblems
{
    internal class PartitionProblem
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
    }
}
