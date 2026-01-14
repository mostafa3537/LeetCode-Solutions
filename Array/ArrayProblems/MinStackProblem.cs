using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ArrayProblems
{
	internal class MinStackProblem
	{
		public class MinStack
		{
			private List<int> _stack { get; set; } = new List<int>();
			private int _min { get; set; } = 0;
			public MinStack()
			{
				_stack = new List<int> { };
			}

			public void Push(int val)
			{
				if (_stack.Count == 0)
				{
					_min = val;
				}
				else
				{
					if (val < _min)
					{
						_min = val;
					}
				}
				_stack.Add(val);

			}

			public void Pop()
			{
				if (_stack.Count == 0)
				{
					_min = 0;
					return;
				}
				var lastIndex = _stack.Count - 1;
				_stack.RemoveAt(lastIndex);

				if (_stack.Count > 0)
				{
					_min = _stack.Min();

				}

			}

			public int Top()
			{
				return _stack[^1];
			}

			public int GetMin()
			{
				return _min;
			}
		}
	}

	public class MinStackEnhanced
	{
		private Stack<int> stack = new();
		private Stack<int> minStack = new();

		public void Push(int val)
		{
			stack.Push(val);

			if (minStack.Count == 0 || val <= minStack.Peek())
				minStack.Push(val);
		}

		public void Pop()
		{
			if (stack.Pop() == minStack.Peek())
				minStack.Pop();
		}

		public int Top()
		{
			return stack.Peek();
		}

		public int GetMin()
		{
			return minStack.Peek();
		}
	}

}
