using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LinkedListProblems
{
    internal class HasCycleProblem
    {
        public static bool HasCycle(ListNode head)
        {
            if (head == null)
            {
                return false;
            }

            // loop over stor the visited nodes in a hashset, if we see a node that is already in the hashset, then we have a cycle

            var result = false;
            HashSet<ListNode> visited = new HashSet<ListNode>();

            ListNode current = head;

            while (current != null)
            {
                if (visited.Contains(current))
                {
                    result = true;
                    break;
                }
                visited.Add(current);
                current = current.next;
            }

            return result;
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
