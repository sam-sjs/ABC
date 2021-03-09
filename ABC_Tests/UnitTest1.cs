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

        [Fact]
        // Do I need a test to check it can create an object before this one? Can't figure out how to assert
        public void GivenGenerateBlock_WhenInputIsTwoStrings_ThenShouldReturnBlockObject()
        {
            string input1 = "A";
            string input2 = "Q";

            Block testBlock = new Block(input1, input2);

            Assert.Equal(input1, testBlock.Side1);
            Assert.Equal(input2, testBlock.Side2);
        }
    }
}    