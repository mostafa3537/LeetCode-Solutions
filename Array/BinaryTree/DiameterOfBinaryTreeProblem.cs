using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.BinaryTree
{
    internal class DiameterOfBinaryTreeProblem
    {
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            int diameter = 0;
            Depth(root, ref diameter);
            return diameter;
        }

        private static int Depth(TreeNode node, ref int diameter)
        {
            if (node == null) return 0;

            int left = Depth(node.left, ref diameter);
            int right = Depth(node.right, ref diameter);

            // update diameter (edges count)
            diameter = Math.Max(diameter, left + right);

            // return height
            return Math.Max(left, right) + 1;
        }
    }
}
