namespace Src._10_Oct;

public class NextBeautifulNumberSolution
{
    public static int NumericallyBalanced(int n)
    {
        while (true)
        {
            n++;
            if (IsNumericallyBalanced(n))
                return n;
        }
    }

    public static bool IsNumericallyBalanced(int x)
    {
        var cnt = new int[10];

        var y = x;
        while (y > 0)
        {
            var d = y % 10;

            if (d == 0) return false;

            cnt[d]++;

            if (cnt[d] > d) return false;

            y /= 10;
        }

        for (var d = 1; d <= 9; d++)
            if (cnt[d] > 0 && cnt[d] != d)
                return false;

        return true;
    }
}