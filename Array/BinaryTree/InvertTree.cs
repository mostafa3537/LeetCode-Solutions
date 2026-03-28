using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.BinaryTree;

internal class InvertTreeProblem
{
    public TreeNode InvertTree(TreeNode root)
    {
        var queue = new Queue<TreeNode>();

        if (root != null)
        {
            queue.Enqueue(root);
        }

        while (queue.Count > 0)
        {
            var levelSize = queue.Count;

            // loop through the current level and add the last node to the result
            for (int i = 0; i < levelSize; i++)
            {
                var current = queue.Dequeue();

                TreeNode temp;

                temp = current.left;
                current.left = current.right;
                current.right = temp;

                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }

                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }
        }

        return root;

    }
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