using System.Linq;

namespace Problems;

internal class Program
{
	public static void IsAnagram(int[] nums)
	{

 
	}
	static void Main(string[] args)
	{
		//[ "getMin","pop","top","getMin","pop","getMin","pop"]
		MinStack minStack = new MinStack();
		minStack.Push(-2);
		minStack.Push(0);
		minStack.Push(-3);
		minStack.GetMin(); // return -3
		minStack.Pop();
		minStack.GetMin(); // return -3
		minStack.Top();    // return 0
		minStack.GetMin(); // return -2
		minStack.Pop();
		minStack.Push(0);
		minStack.Push(0);
		minStack.Push(0);
		minStack.GetMin(); // return -3
		minStack.Pop();
		minStack.Top();    // return 0
		minStack.GetMin(); // return -3
		minStack.Pop();
		minStack.GetMin(); // return -3
		minStack.Pop();

		//var result = IsAnagram(s);

		//Console.WriteLine(result);
	}

	public class MinStack
	{
		private List<int> _stack { get; set; }= new List<int>();
		private int _min{ get; set; } = 0;
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
