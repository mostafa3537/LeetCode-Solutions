namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
{
    public static int MajorityElement(int[] nums)
    {
        var result = 0;

        var limit = nums.Length / 2;


        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.TryGetValue(nums[i], out int val))
            {
                dict[nums[i]] = val + 1;
            }
            else
            {
                dict[nums[i]] = 1;
            }
        }

        dict.Keys.ToList().ForEach(key =>
        {
            if (dict[key] > limit)
            {
                result = key;
            }
        });

        return result;
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
        var list = new int[] { 2, 2, 1, 1, 1, 2, 2 };

        var res = MajorityElement(list);

        Console.WriteLine(res);
    }
}
