using System;
using System.Linq;

namespace T01._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = info[0];
            int cols = info[1];

            int[,] table = new int[rows, cols];

            int sum = 0;

            for (int row = 0; row < table.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    sum += input[col];
                    table[row, col] = input[col];
                }
            }

            Console.WriteLine(table.GetLength(0));
            Console.WriteLine(table.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
