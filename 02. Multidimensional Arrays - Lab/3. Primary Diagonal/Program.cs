using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimentions = int.Parse(Console.ReadLine());
            int rows = dimentions;
            int cols = dimentions;


            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];

                }
            }
            int diagonalSum = 0;
            for (int col = 0; col < cols; col++)
            {
                diagonalSum += matrix[col, col];
            }
            Console.WriteLine(diagonalSum);
        }

    }
}
