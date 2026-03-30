namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
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

        var res = DiameterOfBinaryTree(root);

        Console.WriteLine(res);
    }
}
