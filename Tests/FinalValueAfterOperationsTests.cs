using FluentAssertions;
using Src;

namespace Tests;

public class FinalValueAfterOperationsTests
{
    [Theory]
    [InlineData(new[] { "--X", "X++", "X++" }, 1)]
    [InlineData(new[] { "++X", "++X", "X++" }, 3)]
    [InlineData(new[] { "X++", "++X", "--X", "X--" }, 0)]
    public void FinalValue_Works_For_Cases(string[] operations, int expected)
    {
        // Act
        var result = FinalValueAfterOperationsSolution.FinalValueAfterOperations(operations);

        // Assert
        result.Should().Be(expected);
    }
}
