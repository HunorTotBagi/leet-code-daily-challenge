namespace Src;

public class HasSameDigitsSolution
{
    public static bool HasSameDigits(string s)
    {
        var numbers = new List<int>();

        foreach (var c in s)
        {
            numbers.Add(c - '0');
        }

        while (numbers.Count > 2)
        {
            var newNumbers = new List<int>();
            for (var i = 0; i < numbers.Count-1; i++)
            {
                var number = (numbers[i] + numbers[i + 1]) % 10;
                newNumbers.Add(number);
            }

            numbers = newNumbers;
        }

        if (numbers[0] == numbers[1])
            return true;

        return false;
    }
}
