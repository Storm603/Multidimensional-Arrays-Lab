using System;
using System.Linq;

namespace T04._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new Char[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input.ElementAt(j);
                }
            }

            char searchedSymb = char.Parse(Console.ReadLine());

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == searchedSymb)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }


            Console.WriteLine($"{searchedSymb} does not occur in the matrix");
        }
    }
}
