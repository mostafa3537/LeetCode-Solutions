using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.BinaryTree
{
	internal class IsSubtreeProblem
	{

		public static bool IsSubtree(TreeNode root, TreeNode subRoot)
		{
			if (root == null && subRoot == null)
			{
				return true;
			}
			if (root == null || subRoot == null)
			{
				return false;
			}

			if (IsSame(root, subRoot))
			{
				return true;
			}

			return IsSubtree(root.left, subRoot) ||
				IsSubtree(root.right, subRoot);
		}
		public static bool IsSame(TreeNode root, TreeNode subRoot)
		{
			if (root == null && subRoot == null)
			{
				return true;
			}
			if (root == null || subRoot == null)
			{
				return false;
			}

			if (root.val != subRoot.val)
			{
				return false;
			}
			return IsSame(root.left, subRoot.left) &&
				IsSame(root.right, subRoot.right);
		}
	}
}
