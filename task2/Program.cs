using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block();
            Block block2 = new Block(10, 10, 10, 10);
            Block block3 = new Block(2, 2, 4, 6);

            Block[] blocks = { block1, block2, block3 };

            foreach (Block element in blocks)
                Console.WriteLine(element);

            Console.WriteLine(new string('-', 60));

            for (int i = 0; i < blocks.Length - 1; i++)
                Console.WriteLine(Block.Equals(blocks[i], blocks[i + 1]));
        }
    }
}
