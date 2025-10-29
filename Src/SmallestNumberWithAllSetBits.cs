namespace Src;

public class SmallestNumberWithAllSetBits
{
    public static int SmallestNumber(int n)
    {
        var ones = "1";

        while (ConvertFromBinaryToNumber(ones) < n)
            ones += "1";

        return ConvertFromBinaryToNumber(ones);
    }

    public static int ConvertFromBinaryToNumber(string input)
    {
        var result = 0;
        var length = input.Length;
        foreach (var c in input)
        {
            result += (int)Math.Pow(2, length-1);
            length--;
        }

        return result;
    }
}

