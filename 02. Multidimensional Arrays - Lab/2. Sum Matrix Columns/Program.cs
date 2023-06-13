using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimentions = Console.ReadLine().Split(", ");
            int rows = int.Parse(dimentions[0]);
            int cols = int.Parse(dimentions[1]);


            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];

                }
            }

            for (int col = 0; col < cols; col++)
            {
                int sumMatrixColumns = 0;
                for (int row = 0; row < rows; row++)
                {
                    sumMatrixColumns += matrix[row, col];
                }
                Console.WriteLine(sumMatrixColumns);
            }
        }
    }
}
