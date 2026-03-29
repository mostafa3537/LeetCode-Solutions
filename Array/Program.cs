namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
{
    public static TreeNode InvertTree(TreeNode root)
    {
        var queue = new Queue<TreeNode>();

        var result = new List<int>();
        if (root != null)
        {
            queue.Enqueue(root);
        }

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if (current.left != null)
            {
                queue.Enqueue(current.left);
            }

            if (current.right != null)
            {
                queue.Enqueue(current.right);
            }

            result.Add(current.val);
        }

        result.Sort();


        return BuildBalanced(result, 0, result.Count - 1);

    }


    private static TreeNode BuildBalanced(List<int> arr, int left, int right)
    {
        if (left > right) return null;

        int mid = left + (right - left) / 2;

        var node = new TreeNode(arr[mid]);
        node.left = BuildBalanced(arr, left, mid - 1);
        node.right = BuildBalanced(arr, mid + 1, right);

        return node;
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
        //list1 = [4,2,7,1,3,6,9] 
        //list1 = [4,7,2,9,6,3,1]
        TreeNode root = new TreeNode(4);
        root.left = new TreeNode(2);
        root.right = new TreeNode(7);

        root.left.left = new TreeNode(1);
        root.left.right = new TreeNode(3);

        root.right.left = new TreeNode(6);
        root.right.right = new TreeNode(9);

        var x = InvertTree(root);

        Console.WriteLine();
    }
}
