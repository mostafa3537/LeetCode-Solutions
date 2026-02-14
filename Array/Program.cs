namespace Problems;

internal class Program
{
    public static int ExclusiveTime(string s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            switch (c)
            {
                case '(':
                    stack.Push(c);
                    break;
                case ')':
                    if (stack.TryPeek(out char res) && res == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(c);

                    }
                    break;

            }
        }

        return stack.Count;
    }


    static void Main(string[] args)
    {
        var path = "(((";

        var res = ExclusiveTime(path);

        Console.WriteLine(res);
    }
}
