using FluentAssertions;
using Src._10_Oct;

namespace Tests._10_Oct;

public class CalculateMoneyinLeetcodeBankTests
{
    [Theory]
    [InlineData(4, 10)]
    [InlineData(10, 37)]
    [InlineData(20, 96)]
    public void Test(int days, int expected)
    {
        // Act
        var result = CalculateMoneyinLeetcodeBankSolution.TotalMoney(days);

        // Assert
        result.Should().Be(expected);
    }
}
