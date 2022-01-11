using System;
using System.Linq;

namespace T02._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] info = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = info[0];
            int cols = info[1];

            int[,] table = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    table[i, j] = numbers[j];
                }
            }

            

            for (int col = 0; col < table.GetLength(1); col++)
            {
                int sum = 0;

                for (int row = 0; row < table.GetLength(0); row++)
                {
                    sum += table[row, col];
                }

                Console.WriteLine(sum);
            }

        }
    }
}
