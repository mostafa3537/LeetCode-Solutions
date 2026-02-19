namespace Problems;

internal class Program
{
    public static int[][] KClosest(int[][] points, int k)
    {
        var result = new int[k][];

        var priority = new PriorityQueue<int[], double>();

        for (int i = 0; i < points.Length; i++)
        {
            var point = points[i];


            var distance = Math.Pow(point[0], 2) + Math.Pow(point[1], 2);

            priority.Enqueue(point, distance);
        }

        var length =  k ;

        for (int i = 0; i < length; i++)
        {
            var result2 = priority.Dequeue();

            result[i] = result2;
        }

        return result;
    }


    static void Main(string[] args)
    {
        var path = new int[][] { [3, 3], [5, -1], [-2, 4] };
        var k = 2;

        var res = KClosest(path, k);

        Console.WriteLine(res);
    }
}
