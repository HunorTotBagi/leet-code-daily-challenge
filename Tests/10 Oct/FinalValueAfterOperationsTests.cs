using FluentAssertions;
using Src._10_Oct;

namespace Tests._10_Oct;

public class FinalValueAfterOperationsTests
{
    [Theory]
    [InlineData(new[] { "--X", "X++", "X++" }, 1)]
    [InlineData(new[] { "++X", "++X", "X++" }, 3)]
    [InlineData(new[] { "X++", "++X", "--X", "X--" }, 0)]
    public void FinalValueAfterOperations(string[] operations, int expected)
    {
        // Act
        var result = FinalValueAfterOperationsSolution.FinalValueAfterOperations(operations);

        // Assert
        result.Should().Be(expected);
    }
}
