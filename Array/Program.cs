using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ArrayProblems;

internal class Program
{
	public static bool IsAnagram(string s, string t)
	{
		// loop over first strin add each letter in dic
		// loop over second on check if all the leters appears

		if (string.IsNullOrWhiteSpace(s))
		{ return false; }

		if (string.IsNullOrWhiteSpace(t))
		{ return false; }


		if (s.Length != t.Length)
		{ return false; }

		var dic = new Dictionary<char, int>();

		for (int i = 0; i < s.Length; i++)
		{

			if (dic.ContainsKey(s[i]))
			{
				dic[s[i]]++;
			}
			else
			{
				dic[s[i]] = 1;
			}
		}

		for (int i = 0; i < t.Length; i++)
		{
			if (dic.TryGetValue(t[i], out var val))
			{
				if (val == 0)
				{
					return false;
				}
			}

			if (dic.ContainsKey(t[i]))
			{
				dic[t[i]]--;
			}
			else
			{
				return false;
			}

		}

		return true;
	}
	static void Main(string[] args)
	{
		var s = "rat";
		var t = "car";

		var result = IsAnagram(s, t);

		Console.WriteLine(result);
	}
}
