using System;
using Xunit;

namespace PalindromeExercise
{
    public class WordSmith_Test
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("kayak", true)]
        [InlineData("John", false)]
        [InlineData("Jose", false)]
        [InlineData("Richard", false)]
        [InlineData("madam", true)]
        [InlineData("", false)]
        [InlineData(null, false)]

        public void IsAPalindrome_Test(string word, bool expected)
        {
            // Arrange
            var ws = new WordSmith();

            //Act
            var actual = ws.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
