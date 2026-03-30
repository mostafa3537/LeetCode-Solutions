namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
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

    static void Main(string[] args)
    {
        //list1 = [1,2,3,4,5]
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);

        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);

        var res = IsSameTree(root, root);

        Console.WriteLine(res);
    }
}
