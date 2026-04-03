namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using Problems.BinaryTree;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    public static TreeNode SortedArrayToBST(int[] nums)
    {
        var root = BuildTree(nums, 0, nums.Length - 1);

        return root;
    }

    private static TreeNode BuildTree(int[] nums, int left, int right)
    {
        if (left > right) return null;
        var mid = left + (right - left) / 2;
        var node = new TreeNode(nums[mid]);
        node.left = BuildTree(nums, left, mid - 1);
        node.right = BuildTree(nums, mid + 1, right);
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
        var nums = new int[] { -10, -3, 0, 5, 9 };

        var res = SortedArrayToBST(nums);
        Console.WriteLine();
    }
}
