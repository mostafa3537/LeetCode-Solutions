namespace Array;

internal class Program
{
    public static int[] PlusOne(int[] digits)
    {
        var length = digits.Length;

        var right = length - 1;


        while (right >= 0 && digits[right] == 9)
        {
            digits[right] = 0;
            right--;
        }
        if (right < 0)
        {

            var newDigits = new int[length + 1];

            newDigits[0] = 1;

            return newDigits;
        }

        else
        {
            digits[right]++;
            return digits;
        }

    }

    static void Main(string[] args)
    {
        var nums = new int[] { 9, 9, 9 };

        var result = PlusOne(nums);

        Console.WriteLine(result);
    }
}

