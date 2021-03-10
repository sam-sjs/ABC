using ABC;
using Xunit;

namespace ABC_Tests
{
    public class BlockTests
    {
        [Fact]
        public void GivenBlock_WhenInputIsTwoStrings_ThenShouldReturnBlockWithProperties()
        {
            char input1 = 'A';
            char input2 = 'Q';

            Block actual = new Block(input1, input2);

            Assert.Equal(input1, actual.Side1);
            Assert.Equal(input2, actual.Side2);
        }
    }
}