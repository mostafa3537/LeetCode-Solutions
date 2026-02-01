using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Stack
{
	internal class SimplifyPathProblem
	{
		public static string SimplifyPath(string path)
		{
			var result = string.Empty;

			var stack = new Stack<string>();

			var segments = path.Split('/', StringSplitOptions.RemoveEmptyEntries);


			for (int i = 0; i < segments.Length; i++)
			{
				var segment = segments[i];
				if (segment == ".")
				{
					continue;
				}

				if (segment == "..")
				{
					if (stack.Count > 0)
					{
						stack.Pop();
					}
					continue;
				}

				stack.Push(segment);

			}

			var stringList = new List<string>();

			while (stack.Count > 0)
			{
				var segment = stack.Pop();

				if (segment.Length == 0)
				{
					continue;
				}

				stringList.Add(segment);
			}

			for (int i = stringList.Count - 1; i >= 0; i--)
			{
				result += $"/{stringList[i]}";
			}

			if (stringList.Count == 0)
			{
				result = "/";
			}
			return result;
		}
	}
}
