
namespace ABC
{
    public class WordGenerator
    {
        private static Block block1 = new Block('X', 'K');
        private static Block block2 = new Block('B', 'O');
        private static Block block3 = new Block('D', 'Q');
        private static Block block4 = new Block('C', 'P');
        private static Block block5 = new Block('N', 'A');
        private static Block block6 = new Block('G', 'T');
        private static Block block7 = new Block('R', 'E');
        private static Block block8 = new Block('T', 'G');
        private static Block block9 = new Block('Q', 'D');
        private static Block block10 = new Block('F', 'S');
        private static Block block11 = new Block('J', 'W');
        private static Block block12 = new Block('H', 'U');
        private static Block block13 = new Block('V', 'I');
        private static Block block14 = new Block('A', 'N');
        private static Block block15 = new Block('O', 'B');
        private static Block block16 = new Block('E', 'R');
        private static Block block17 = new Block('F', 'S');
        private static Block block18 = new Block('L', 'Y');
        private static Block block19 = new Block('P', 'C');
        private static Block block20 = new Block('Z', 'M');

        private static Block[] blocks = new Block[]
        {
            block1, block2, block3, block4, block5, block6, block7, block8, block9, block10,
            block11, block12, block13, block14, block15, block16, block17, block18, block19, block20
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