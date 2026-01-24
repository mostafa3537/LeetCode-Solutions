using System.Linq;

namespace Problems;

internal class Program
{
    public static bool IsAlienSorted(string[] words, string order)
    {
        // make a dic with all the char and it' priority
        // loop over the words compare each one on with the next thier first letter 
        // if its the same for all letters take the shorter

        var dic = new Dictionary<char, int>();

        for (int i = 0; i < order.Length; i++)
        {
            dic.Add(order[i], i);
        }

        for (int i = 0; i < words.Length - 1; i++)
        {
            var word = words[i];
            var nextWord = words[i + 1];

            for (int j = 0; j < word.Length; j++)
            {
                if (dic.TryGetValue(word[j], out int val) && dic.TryGetValue(nextWord[j], out int nextVal))
                {
                    if (nextVal < val)
                    {
                        return false;
                    }
                    else if (nextVal == val)
                    {
                        if (j == word.Length-1 || j == nextWord.Length - 1)
                        {
                            if (word.Length > nextWord.Length)
                            {
                                return false;
                            }
                        }
                        continue;   
                    }
                    else
                    {
                        break;
                    }
                }

            }

        }

        return true;
    }

    static void Main(string[] args)
    {
        var words = new string[] { "apple", "app" };
        var order = "abcdefghijklmnopqrstuvwxyz";

        var result = IsAlienSorted(words, order);

        Console.WriteLine(result);
    }
}
