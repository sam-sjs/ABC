using System;
using ABC;
using Xunit;
using Xunit.Sdk;

namespace ABC_Tests
{
    public class WordGeneratorTests
    {
        [Theory]
        [InlineData("A", true)]
        [InlineData("a", true)]
        [InlineData("B", true)]
        [InlineData("b", true)]
        [InlineData("BARK", true)]
        [InlineData("BOOK", false)]
        public void GivenCanMakeWord_WhenInputIsAString_ThenShouldReturnBool(string input, bool expected)
        {
            bool actual = WordGenerator.CanMakeWord(input);

            Assert.Equal(expected, actual);
        }
    }
}    