using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.BinaryTree
{
    internal class RightSideViewProblem
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var result = new List<int>();

            var queue = new Queue<TreeNode>();

            if (root != null)
            {
                queue.Enqueue(root);
            }


            while (queue.Count > 0)
            {
                var levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    var current = queue.Dequeue();

                    if (i == levelSize - 1)
                    {
                        result.Add(current.val);
                    }

                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }
            }


            return result;
        }
    }
}
