namespace Src._10_Oct;

public class CalculateMoneyinLeetcodeBankSolution
{
    public static int TotalMoney(int n)
    {
        var times = n / 7;
        var reminder = n % 7;

        var list = new List<int>();

        for (var i = 0; i < times; i++)
            list.Add(7+i);

        list.Add(reminder+times);

        var totalMoney = 0;

        var k = 1;
        foreach (var item in list)
        {
            for (var j = k; j <= item; j++)
                totalMoney += j;

            k++;
        }

        return totalMoney;
    }
}
