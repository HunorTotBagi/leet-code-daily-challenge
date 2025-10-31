using FluentAssertions;
using Src._10_Oct;

namespace Tests._10_Oct
{
    public class LexicographicallySmallestStringTests
    {
        [Theory]
        [InlineData("3456", 5, "3951")]
        [InlineData("2555", 9, "2454")]
        [InlineData("47", 5, "42")]
        public void Test1(string s, int a, string expected)
        {
            // Act
            var result = LexicographicallySmallestString.ApplyOperationA(s, a);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("3456", 1,"6345")]
        [InlineData("1234567", 3, "5671234")]
        [InlineData("489", 2, "894")]
        public void ApplyOperationB(string s, int b, string expected)
        {
            // Act
            var result = LexicographicallySmallestString.ApplyOperationB(s, b);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("0158", "0190", true)]
        [InlineData("0158", "0158", false)]
        [InlineData("6547777", "1547777", false)]
        public void IsLexicographicallySmaller(string a, string b, bool expected)
        {
            // Act
            var result = LexicographicallySmallestString.IsLexicographicallySmaller(a, b);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("5525", 9, 2, "2050")]
        [InlineData("74", 5, 1, "24")]
        [InlineData("0011", 4, 2, "0011")]
        public void FindLexSmallestString(string s, int a, int b, string expected)
        {
            // Act
            var result = LexicographicallySmallestString.FindLexSmallestString(s, a, b);

            // Assert
            result.Should().Be(expected);
        }
    }
}
