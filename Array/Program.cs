namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
{
    public static bool IsSymmetric(TreeNode root)
    {
        var listLeft = new List<int?>();
        DFSPreOrder(root.left, listLeft);

        var listRight = new List<int?>();
        DFSPreOrderInvert(root.right, listRight);

        if (listLeft.Count != listRight.Count)
        {
            return false;
        }

        for (int i = 0; i < listLeft.Count; i++)
        {
            if (listLeft[i] != listRight[i])
            {
                return false;
            }
        }
        return true;
    }

    private static void DFSPreOrder(TreeNode node, List<int?>? res)
    {
        if (node == null) {
            res.Add(null);
            return;
        }
        res.Add(node.val);

        DFSPreOrder(node.left, res);
        DFSPreOrder(node.right, res);
    }  
    
    private static void DFSPreOrderInvert(TreeNode node, List<int?>? res)
    {
        if (node == null){
            res.Add(null);
            return;
        }
        res.Add(node.val);

        DFSPreOrderInvert(node.right, res);
        DFSPreOrderInvert(node.left, res);
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
        //list1 = [1,2,2,2,null,2] 
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(2);

        root.left.left = new TreeNode(3);
        root.left.right = new TreeNode(4);

        root.right.left = new TreeNode(4);
        root.right.right = new TreeNode(3);

        var res = IsSymmetric(root);

        Console.WriteLine(res);
    }
}
