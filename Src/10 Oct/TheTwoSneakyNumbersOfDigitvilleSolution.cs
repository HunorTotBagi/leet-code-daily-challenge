namespace Src._10_Oct;

public class TheTwoSneakyNumbersOfDigitvilleSolution
{
    public static int[] GetSneakyNumbers(int[] nums)
    {
        var dict = new Dictionary<int, int>();

        foreach (var number in nums)
        {
            if (dict.ContainsKey(number))
                dict[number]++;

            else
                dict[number] = 1;
        }

        var i = 0;
        var result = new int[2];
        foreach (var x in dict.Keys)
        {
            if (dict[x] == 2)
            {
                result[i] = x;
                i++;
            }
        }

        return result;
    }
}
