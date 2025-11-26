using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayprob;

internal class LongestCommonPrefixProblem
{
    public string LongestCommonPrefix(string[] strs)
    {
        var result = "";

        var firstWord = strs[0];

        var firstWordcharchters = firstWord.Select(x => x).ToList();

        var smallestWordLength = strs.MinBy(x => x.Length).Count();

        firstWordcharchters.RemoveRange(smallestWordLength, firstWordcharchters.Count - smallestWordLength);

        for (int charcter = 0; charcter < firstWordcharchters.Count; charcter++)
        {
            var isAdd = true;

            for (int word = 0; word < strs.Length; word++)
            {
                if (word == 0)
                {
                    continue;
                }
                if (strs[word].Length < firstWordcharchters.Count)
                {
                    return result;
                }
                // check if all words have the same charcter at the current position
                if (strs[word][charcter] != firstWordcharchters[charcter])
                {
                    isAdd = false;
                    return result;
                }
            }

            if (isAdd)
            {
                result += firstWordcharchters[charcter];
            }
        }

        return result;
    }
    public static string LongestCommonPrefixOptimized(string[] strs)
    {
        var result = "";

        var firstWord = strs[0];

        for (int i = 0; i < firstWord.Length; i++)
        {
            char currentChar = firstWord[i];

            for (int j = 1; j < strs.Length; j++)
            {
                if (i > strs[j].Length || strs[j][i] != currentChar)
                {
                    result = firstWord.Substring(0, i);
                    return result;
                }

            }

        }

        return result;
    }
}
