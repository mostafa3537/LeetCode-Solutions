using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems.BinaryTree;

namespace Problems.BinaryTreeProblems
{
    internal class SortedArrayToBSTProblem
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

    }
}
