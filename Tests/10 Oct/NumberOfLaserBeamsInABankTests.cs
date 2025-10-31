using FluentAssertions;
using Src._10_Oct;

namespace Tests._10_Oct;

public class NumberOfLaserBeamsInABankTests
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var input = new string[] { "011001", "000000", "010100", "001000" };
        var expected = 8;

        // Act
        var result = NumberOfLaserBeamsInABankSolution.NumberOfBeams(input);

        // Assert
        result.Should().Be(expected);

    }
}
