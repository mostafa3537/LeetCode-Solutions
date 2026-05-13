namespace Problems;

using System;
using System.Collections.Generic;


internal class Program
{
	public class RandomizedSet
	{
		public Dictionary<int, int> KeyValues { get; set; }

		public RandomizedSet()
		{
			KeyValues = new Dictionary<int, int>();
		}

		public bool Insert(int val)
		{

			if (KeyValues.ContainsKey(val)) 
			{
				return false;
			}
			else
			{
				KeyValues.Add(val, val);
				return true;
			}
		}

		public bool Remove(int val)
		{
			if (KeyValues.TryGetValue(val, out int val2))
			{
				KeyValues.Remove(val);

				return true;
			}
			else
			{
				return false;
			}

		}

		public int GetRandom()
		{
			var random = new Random();

			int value = random.Next(0, KeyValues.Count);

			return KeyValues.ElementAt(value).Value;
		}
	}

	static void Main(string[] args)
	{
		RandomizedSet obj = new RandomizedSet();
		bool param_1 = obj.Insert(1);
		bool param_2 = obj.Remove(2);
		int param_3 = obj.GetRandom();


		Console.WriteLine();
	}
}
