namespace Problems;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

internal class Program
{
    public static int FindLHS(int[] nums)
    {
        var result = 0;

        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.TryGetValue(nums[i], out int val))
            {
                dic[nums[i]]++;
            }
            else
            {
                dic.Add(nums[i], 1);
            }
        }

        foreach (var item in dic)
        {
            if (dic.TryGetValue(item.Key + 1, out int val))
            {
                result = Math.Max(result, item.Value + val);
            }
        }

        return result;
    }


    static void Main(string[] args)
    {
        var list = new int[] { 1, 3, 2, 2, 5, 2, 3, 7 };

        var res = FindLHS(list);
        Console.WriteLine(res);
    }
}
