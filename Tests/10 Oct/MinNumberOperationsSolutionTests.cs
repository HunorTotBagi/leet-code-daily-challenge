using FluentAssertions;
using Src._10_Oct;

namespace Tests._10_Oct;

public class MinNumberOperationsSolutionTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 2, 1 }, 3)]
    [InlineData(new[] { 3, 1, 1, 2 }, 4)]
    [InlineData(new[] { 3, 1, 5, 4, 2 }, 7)]
    public void Test1(int[] input, int expected)
    {
        // Act
        var result = MinNumberOperationsSolution.MinNumberOperations(input);

        // Assert
        result.Should().Be(expected);
    }
}
