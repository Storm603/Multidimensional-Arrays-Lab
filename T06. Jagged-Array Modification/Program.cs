using System;
using System.Linq;

namespace T06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {

            int rowscols = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rowscols][];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i] = new int[rowscols];
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < matrix[i].GetLength(0); j++)
                {
                    matrix[i][j] = input[j];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] split = command.Split();
                string action = split[0];
                int row = int.Parse(split[1]);
                int col = int.Parse(split[2]);
                int num = int.Parse(split[3]);

                if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].GetLength(0))
                {
                    if (action == "Add")
                    {
                        matrix[row][col] += num;
                    }
                    else if (action == "Subtract")
                    {
                        matrix[row][col] -= num;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].GetLength(0); j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
