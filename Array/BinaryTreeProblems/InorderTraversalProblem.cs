using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.BinaryTreeProblems
{
    internal class InorderTraversalProblem
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            var res = new List<int>();

            DFS(root, res);

            return res;
        }

        private static void DFS(TreeNode node, List<int>? res)
        {
            if (node == null) return;
            DFS(node.left, res);
            res.Add(node.val);
            DFS(node.right, res);
        }


        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
