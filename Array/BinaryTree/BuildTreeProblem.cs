using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.BinaryTree
{
    internal class BuildTreeProblem
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            var tree = new TreeNode();

            if (preorder.Length < 1 || inorder.Length < 1)
            {
                return tree;
            }

            Build(tree, preorder, inorder);

            return tree;
        }

        private static void Build(TreeNode tree, int[] preorder, int[] inorder)
        {
            var rootValue = preorder.First();

            tree.val = rootValue;

            var rootIndexInorder = Array.IndexOf(inorder, rootValue);

            var leftInorder = inorder.Take(rootIndexInorder).ToArray();
            var rightInorder = inorder.Skip(rootIndexInorder + 1).ToArray();

            var leftPreorder = preorder.Skip(1).Take(leftInorder.Length).ToArray();
            var rightPreorder = preorder.Skip(1 + leftInorder.Length).ToArray();

            if (leftPreorder.Length > 0)
            {
                tree.left = new TreeNode();
                Build(tree.left, leftPreorder, leftInorder);
            }

            if (rightPreorder.Length > 0)
            {
                tree.right = new TreeNode();
                Build(tree.right, rightPreorder, rightInorder);
            }

        }
    }
}
