using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.BinaryTree
{
    internal class BalanceBSTProblem
    {
        public static TreeNode BalanceBST(TreeNode root)
        {
            var queue = new Queue<TreeNode>();

            var result = new List<int>();
            if (root != null)
            {
                queue.Enqueue(root);
            }

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }

                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }

                result.Add(current.val);
            }

            result.Sort();


            return BuildBalanced(result, 0, result.Count - 1);

        }


        private static TreeNode BuildBalanced(List<int> arr, int left, int right)
        {
            if (left > right) return null;

            int mid = left + (right - left) / 2;

            var node = new TreeNode(arr[mid]);
            node.left = BuildBalanced(arr, left, mid - 1);
            node.right = BuildBalanced(arr, mid + 1, right);

            return node;
        }
    }
}
