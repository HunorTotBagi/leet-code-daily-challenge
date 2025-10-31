using FluentAssertions;
using Src._10_Oct;

namespace Tests._10_Oct;

public class HasSameDigitsTests
{
    [Theory]
    [InlineData("3902", true)]
    [InlineData("34789", false)]
    public void Test1(string s, bool expected)
    {
        // Act
        var result = HasSameDigitsSolution.HasSameDigits(s);

        // Assert
        result.Should().Be(expected);
    }
}
