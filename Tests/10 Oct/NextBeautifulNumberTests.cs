using FluentAssertions;
using Src._10_Oct;

namespace Tests._10_Oct;

public class NextBeautifulNumberTests
{
    [Theory]
    [InlineData(1,22)]
    [InlineData(1000,1333)]
    [InlineData(3000,3133)]
    public void Test1(int n, int expected)
    {
        // Act
        var result = NextBeautifulNumberSolution.NumericallyBalanced(n);

        // Assert
        result.Should().Be(expected);
    }
}
