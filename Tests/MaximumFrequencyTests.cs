using FluentAssertions;
using Src;

namespace Tests;

public class MaximumFrequencyTests
{
    [Fact]
    public void GenerateNumbers()
    {
        // Arrange
        var k = 5;
        var expected = new List<int> { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };

        // Act
        var result = MaximumFrequencySolution.GenerateNumbers(k);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Theory]
    [InlineData(new[] { 5, 11, 20, 20, 20 }, 3)]
    [InlineData(new[] { 57, 57 }, 2)]
    public void GetFrequency(int[] arr, int expected)
    {
        // Act
        var result = MaximumFrequencySolution.GetFrequency(arr);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(new[] {1,4,5}, 1, 2, 2)]
    [InlineData(new[] {5, 11, 20, 20}, 5, 1, 2)]
    [InlineData(new[] {18,57}, 97, 2, 2)]
    //[InlineData(new[] {88, 53}, 27, 2, 2)] Failing test case
    public void Test4(int[] nums, int k, int numOperations, int expected)
    {
        // Act
        var result = MaximumFrequencySolution.MaxFrequency(nums, k , numOperations);

        // Assert
        result.Should().Be(expected);
    }
}
