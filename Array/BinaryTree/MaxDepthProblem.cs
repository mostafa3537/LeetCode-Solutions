using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.BinaryTree
{
    internal class MaxDepthProblem
    {
        public static int MaxDepth(TreeNode root)
        {
            int diameter = 0;

            var stack = new Stack<(TreeNode, int)>();

            if (root != null)
            {
                stack.Push((root, 1));
            }

            while (stack.Count > 0)
            {
                var (node, depth) = stack.Pop();

                diameter = Math.Max(diameter, depth);
                if (node.left != null)
                {
                    stack.Push((node.left, depth + 1));
                }

                if (node.right != null)
                {
                    stack.Push((node.right, depth + 1));
                }

            }
            return diameter;
        }
    }
}
