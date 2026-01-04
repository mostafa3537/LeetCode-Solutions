using System.Linq;

namespace Arrayprob;

internal class Program
{
    public static int SubarraySum(int[] nums, int k)
    {
        var result = 0;
        var prefixSumDictionary = new Dictionary<int, int>();
        var prefixSum = 0;

        prefixSumDictionary.Add(0, 1); // To handle the case when prefixSum itself is equal to k
        for (int i = 0; i < nums.Length; i++)
        {
            prefixSum += nums[i];

            if (prefixSumDictionary.TryGetValue(prefixSum - k, out int count))
            {
                result = result + count;
            }

            if (prefixSumDictionary.ContainsKey(prefixSum))
            {
                prefixSumDictionary[prefixSum]++;
            }
            else
            {
                prefixSumDictionary.Add(prefixSum, 1);
            }
        }

        return result;
    }
    static void Main(string[] args)
    {
        //var nums = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        var nums = new int[] { 9, -9, 2, 3, 4 };
        var target = 9;

        var result = SubarraySum(nums, target);

        Console.WriteLine(result);
    }
}

