using FluentAssertions;
using Src._10_Oct;

namespace Tests._10_Oct;

public class TheTwoSneakyNumbersOfDigitvilleTests
{
    [Theory]
    [InlineData(new[] { 0, 1, 1, 0 }, new[] {0, 1})]
    [InlineData(new[] { 7, 1, 5, 4, 3, 4, 6, 0, 9, 5, 8, 2 }, new[] {4, 5})]
    public void Test1(int[] input, int[] expected)
    {
        // Act
        var result = TheTwoSneakyNumbersOfDigitvilleSolution.GetSneakyNumbers(input);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}
