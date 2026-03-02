namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
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

    static void Main(string[] args)
    {
        //list1 = [1,null,2,3] 
        TreeNode root = new TreeNode(1);
        root.left = null;
        root.right = new TreeNode(2);
        root.right.left = new TreeNode(3);

        var res = InorderTraversal(root);

        Console.WriteLine(res);
    }
}
