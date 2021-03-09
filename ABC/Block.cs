
namespace ABC
{
    public class Block
    {
        // Should I not be using "this"?
        public Block(string side1, string side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }
        
        public string Side1 { get; }
        public string Side2 { get; }
    }
}