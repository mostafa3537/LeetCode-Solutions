using System.Linq;

namespace ArrayProblems;

internal class Program
{
    public static int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums.Length == 0 || k == 0)
            return Array.Empty<int>();

        var result = new int[nums.Length - k + 1];
        var deque = new LinkedList<int>(); // stores indices

        for (int i = 0; i < nums.Length; i++)
        {
            // 1. Remove indices outside the window
            if (deque.Count > 0 && deque.First.Value <= i - k)
                deque.RemoveFirst();

            // 2. Remove smaller values from the back
            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
                deque.RemoveLast();

            // 3. Add current index
            deque.AddLast(i);

            // 4. Record max once window is ready
            if (i >= k - 1)
                result[i - k + 1] = nums[deque.First.Value];
        }

        return result;
    }
    static void Main(string[] args)
    {
        var nums = new int[] { 1, 3, -1, -3, 5, 3, 6, 7 };
        var target = 3;

        var result = MaxSlidingWindow(nums, target);

        Console.WriteLine(result);
    }
}

