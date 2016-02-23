using LinqAn.Google.Generator.Core;
using Xunit;

namespace LinqAn.Google.Generator.Tests
{
    public class ColumnExtensionsTests
    {
        public ColumnExtensionsTests()
        {
        }

        [Theory]
        [InlineData("ga:21dayUsers","TwentyOneDayUsers")]
        public void GetClassNameWorksAsExpected(string input, string expected)
        {
            // Arrange

            // Act
            var actual = input.GetClassName();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
