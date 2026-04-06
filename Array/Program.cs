

namespace Problems;

internal class Program
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
		//root = [3, 4, 5, 1, 2], subRoot = [4, 1, 2]
		var root = new TreeNode(3);

		root.left = new TreeNode(4);
		root.right = new TreeNode(5);

		root.left.left = new TreeNode(1);
		root.left.right = new TreeNode(2);

		root.right = new TreeNode(5);

		var subRoot = new TreeNode(4);

		subRoot.left = new TreeNode(1);
		subRoot.right = new TreeNode(2);

		var res = IsSubtree(root, subRoot);
		Console.WriteLine(res);
	}
}
