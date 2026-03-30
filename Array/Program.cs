namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
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
                stack.Push((node.left, depth+1));
            }       
            
            if (node.right != null)
            {
                stack.Push((node.right, depth+1));
            }

        }
        return diameter;
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

        var res = MaxDepth(root);

        Console.WriteLine(res);
    }
}
