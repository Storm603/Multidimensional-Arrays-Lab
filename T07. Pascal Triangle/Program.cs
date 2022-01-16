using System;

namespace T07._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowCount = int.Parse(Console.ReadLine());

            long[][] triangle = new long[rowCount][];

            for (int i = 0; i < rowCount; i++)
            {
                triangle[i] = new long[i + 1];
                for (int j = 0; j < triangle[i].Length; j++)
                {
                    if (j == 0 || j == triangle[i].Length - 1)
                    {
                        triangle[i][j] = 1;
                    }
                    else
                    {
                        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    }
                }

                Console.WriteLine(string.Join(" ", triangle[i]));
            }
        }
    }
}
