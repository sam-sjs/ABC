
namespace ABC
{
    public class Block
    {
        public Block(char side1, char side2)
        {
            Side1 = side1;
            Side2 = side2;
        }
        
        public char Side1 { get; }
        public char Side2 { get; }
        public bool BlockAvailable { get; set; } = true;
    }
}