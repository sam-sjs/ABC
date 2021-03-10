using ABC;
using Xunit;

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
        [InlineData("COMMON", false)]
        [InlineData("WOOLLOOMOOLOO", false)]
        [InlineData("TREAT", true)]
        [InlineData("SQUAD", true)]
        [InlineData("CONFUSE", true)]
        public void GivenCanMakeWord_WhenInputIsAString_ThenShouldReturnBool(string input, bool expected)
        {
            WordGenerator generator = new WordGenerator();
            
            bool actual = generator.CanMakeWord(input);

            Assert.Equal(expected, actual);
        }
    }
}    