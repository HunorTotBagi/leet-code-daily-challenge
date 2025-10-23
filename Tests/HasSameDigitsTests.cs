using FluentAssertions;
using Src;

namespace Tests;

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
