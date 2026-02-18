namespace Problems;

internal class Program
{
    public static int FindKthLargest(int[] nums, int k)
    {
        var result = 0;

        var priority = new PriorityQueue<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            priority.Enqueue(nums[i], nums[i]);
        }

        for (int i = 0; i < nums.Length - k + 1; i++)
        {
            result = priority.Dequeue();
        }

        return result;
    }


    static void Main(string[] args)
    {
        var path = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
        var k = 4;

        var res = FindKthLargest(path, k);

        Console.WriteLine(res);
    }
}
