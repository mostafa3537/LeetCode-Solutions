namespace Problems;

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using Problems.BinaryTree;
using static System.Net.Mime.MediaTypeNames;

internal class Program
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
    public static List<int> Pre(TreeNode tree)
    {
        var res = new List<int>();

        PreOrder(tree, res);

        return res;
    }


    public static void PreOrder(TreeNode tree, List<int> res)
    {
        if (tree == null)
        {
            return;
        }

        res.Add(tree.val);

        PreOrder(tree.left, res);
        PreOrder(tree.right, res);

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
        //[3,9,20,null,null,15,7]
        TreeNode tree = new(3);

        tree.left = new(9);
        tree.right = new(20);


        tree.right.left = new(15);
        tree.right.right = new(7);

        var res = Pre(tree);
        Console.WriteLine();
    }
}
