using System;

namespace ABC
{
    class Program
    {
        static void Main(string[] args)
        {
            WordGenerator generator = new WordGenerator();
            string input;
            do
            {
                Console.WriteLine("Input word to be tested (\"1\" to exit):");
                input = Console.ReadLine();
                if (input == "1") break;
                Console.WriteLine(generator.CanMakeWord(input));
            } while (true);
        }
    }
}