using System.Linq;

namespace Problems;

internal class Program
{
	public int MinSteps(string s, string t)
	{
		// sort s and make dic of it's char and freq
		// sort t make the comparason and count replacement

		if (string.IsNullOrWhiteSpace(s))
		{ return 0; }

		if (string.IsNullOrWhiteSpace(t))
		{ return 0; }


		if (s.Length != t.Length)
		{ return 0; }

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

		var result = 0;

		for (int i = 0; i < t.Length; i++)
		{
			if (dic.TryGetValue(t[i], out var val) && val > 0)
			{

				dic[t[i]]--;

			}

			else
			{
				result++;
			}

		}

		return result;
	}

	static void Main(string[] args)
	{
		var s = "gctcxyuluxjuxnsvmomavutrrfb";
		var t = "qijrjrhqqjxjtprybrzpyfyqtzf";

		var result = MinSteps(s, t);

		Console.WriteLine(result);
	}
}
