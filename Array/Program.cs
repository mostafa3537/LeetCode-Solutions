namespace Problems;

internal class Program
{
    public static int MaxEvents(int[][] events)
    {
        var result = 0;

        Array.Sort(events, (a, b) => a[0].CompareTo(b[0]));

        var priority = new PriorityQueue<int[], int>();

        int i = 0;
        int n = events.Length;

        // get last day
        int lastDay = 0;

        for (int j = 0; j < n; j++)
        {
            lastDay = Math.Max(lastDay, events[j][1]);
        }


        for (int day = 0; day <= lastDay; day++)
        {
            //attend all events start today

            while (i < n && events[i][0] == day)
            {
                priority.Enqueue(events[i], events[i][1]);
                i++;
            }

            //remove expired events
            while (priority.Count > 0 && priority.Peek()[1]< day)
            {
                priority.Dequeue();
            }
            //attend event with earliest end day

            if (priority.Count > 0)
            {
                priority.Dequeue();
                result++;
            }
        }

        return result;
    }


    static void Main(string[] args)
    {
        var path = new int[][] { [1, 2], [2, 2], [3, 3], [3, 4], [3, 4] };

        var res = MaxEvents(path);

        Console.WriteLine(res);
    }
}
