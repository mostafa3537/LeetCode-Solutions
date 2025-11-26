namespace Arrayprob;

internal class Program
{

    public static IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var result = new List<IList<int>>();

        var stack = new Stack<(List<int> combo, int sum, int index)>();
        stack.Push((new List<int>(), 0, 0));

        while (stack.Count > 0)
        {
            var (combo, sum, index) = stack.Pop();

            if (sum == target)
            {
                result.Add(combo);
                continue;
            }

            for (int i = index; i < candidates.Length; i++)
            {
                int num = candidates[i];
                int newSum = sum + num;

                if (newSum > target)
                    break;

                var newCombo = new List<int>(combo) { num };
                stack.Push((newCombo, newSum, i));
            }
        }

        return result;
    }


    static void Main(string[] args)
    {
        var nums = new int[] { 2, 3, 6, 7 };
        var target = 7;
        var result = CombinationSum(nums, target);

        Console.WriteLine(result);
    }
}

