using System;
using System.Linq;

namespace T03._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[i];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}
