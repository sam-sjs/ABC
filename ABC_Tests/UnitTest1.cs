using System;
using ABC;
using Xunit;

namespace ABC_Tests
{
    public class WordGeneratorTests
    {
        [Theory]
        [InlineData("A")]
        [InlineData("a")]
        [InlineData("B")]
        [InlineData("b")]
        [InlineData("BARK")]
        public void GivenCanMakeWord_WhenInputIsAString_ThenShouldReturnTrue(string input)
        {
            bool actual = WordGenerator.CanMakeWord(input);

            Assert.True(actual);
        }
    }
}    