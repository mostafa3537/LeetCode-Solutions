using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.BinaryTree
{
    internal class IsSameTreeProblem
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            var result = true;

            if (p == null && q == null)
            {
                return true;
            }

            var queue = new Queue<(TreeNode, TreeNode)>();

            if (p != null && q != null)
            {
                queue.Enqueue((p, q));
            }
            else
            {
                return false;
            }

            while (queue.Count > 0)
            {
                var currentNodes = queue.Dequeue();

                if (currentNodes.Item1.val != currentNodes.Item2.val)
                {
                    return false;
                }

                if (currentNodes.Item1.left != null && currentNodes.Item2.left != null)
                {
                    queue.Enqueue((currentNodes.Item1.left, currentNodes.Item2.left));
                }
                else if (currentNodes.Item1.left != null || currentNodes.Item2.left != null)
                {
                    return false;
                }

                if (currentNodes.Item1.right != null && currentNodes.Item2.right != null)
                {
                    queue.Enqueue((currentNodes.Item1.right, currentNodes.Item2.right));
                }
                else if (currentNodes.Item1.right != null || currentNodes.Item2.right != null)
                {
                    return false;
                }
            }

            return result;
        }
    }
}
