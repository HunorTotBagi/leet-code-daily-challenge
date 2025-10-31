using FluentAssertions;
using Src._10_Oct;

namespace Tests._10_Oct;

public class SmallestNumberWithAllSetBitsTests
{
    [Theory]
    [InlineData("1", 1)]
    [InlineData("11", 3)]
    [InlineData("111", 7)]
    [InlineData("1111", 15)]
    public void ConvertFromBinaryToNumberTest(string input, int expected)
    {
        // Act
        var result = SmallestNumberWithAllSetBits.ConvertFromBinaryToNumber(input);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(5, 7)]
    [InlineData(10, 15)]
    [InlineData(3, 3)]
    public void SmallestNumberTest(int input, int expected)
    {
        // Act
        var result = SmallestNumberWithAllSetBits.SmallestNumber(input);

        // Assert
        result.Should().Be(expected);
    }
}
