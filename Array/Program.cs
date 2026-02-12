using System.Linq;

namespace Problems;

internal class Program
{
	public static int LargestSubmatrix(int[][] matrix)
	{
		// make histogram for each row
		// reorder it desc
		// cal Area & track max

		int maxArea = 0;

		var length = matrix.Length;
		var collength = matrix[0].Length;

		var colCount = new int[collength];

		for (int row = 0; row < length; row++)
		{
			for (int col = 0; col < collength; col++)
			{
				if (matrix[row][col] == 1)
				{
					colCount[col]++;

				}
				else
				{
					colCount[col] = 0;
				}
			}

			var reorderd = ReorderHistogram(colCount);
			var area = CalCulateArea(reorderd);

			maxArea = Math.Max(maxArea, area);
		}

		return maxArea;
	}

	private static int CalCulateArea(int[] reorderd)
	{
		var maxArea = 0;

		for (int i = 0; i < reorderd.Length; i++)
		{
			var area = 0;

			area = reorderd[i] * (i + 1);

			maxArea = Math.Max(maxArea, area);
		}

		return maxArea;
	}

	private static int[] ReorderHistogram(int[] colCount)
	{
		var res = colCount.OrderByDescending(x => x).ToArray();

		return res;
	}

	static void Main(string[] args)
	{
		var path = new int[][] { [1, 0, 1, 0, 1] };

		var res = LargestSubmatrix(path);

		Console.WriteLine(res);
	}
}
