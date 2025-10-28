using FluentAssertions;
using Src;

namespace Tests;

public class MakeArrayElementsEqualToZeroTests
{
    [Fact]
    public void ApplyMovesTest1()
    {
        // Arrange
        var nums = new[] { 1, 0, 2, 0, 3 };
        var position = 3;
        var direction = "left";
        var expected = true;

        // Act
        var result = MakeArrayElementsEqualToZero.ApplyMoves(nums, position, direction);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void ApplyMovesTest2()
    {
        // Arrange
        var nums = new[] { 1, 0, 2, 0, 3 };
        var position = 3;
        var direction = "right";
        var expected = true;

        // Act
        var result = MakeArrayElementsEqualToZero.ApplyMoves(nums, position, direction);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void CountValidSelectionsTest()
    {
        // Arrange
        var nums = new[] { 1, 0, 2, 0, 3 };
        var expected = 2;

        // Act
        var result = MakeArrayElementsEqualToZero.CountValidSelections(nums);

        // Assert
        result.Should().Be(expected);
    }
}
