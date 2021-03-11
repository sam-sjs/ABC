
namespace ABC
{
    public class WordGenerator
    {
        private Block[] blocks = {
            new('X', 'K'), new('B', 'O'), new('D', 'Q'), new('C', 'P'), new('N', 'A'),
            new('G', 'T'), new('R', 'E'), new('T', 'G'), new('Q', 'D'), new('F', 'S'),
            new('J', 'W'), new('H', 'U'), new('V', 'I'), new('A', 'N'), new('O', 'B'),
            new('E', 'R'), new('F', 'S'), new('L', 'Y'), new('P', 'C'), new('Z', 'M')
        };

        public bool CanMakeWord(string input)
        {
            string inputUp = input.ToUpper();
            int matchCount = 0;
            foreach (char letter in inputUp)
            {
                foreach (var block in blocks)
                {
                    if ((letter == block.Side1 || letter == block.Side2) && block.BlockAvailable)
                    {
                        matchCount++;
                        block.BlockAvailable = false;
                        break;
                    }
                }
            }
            return matchCount == input.Length;
        }
    }
}