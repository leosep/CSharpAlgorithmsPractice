using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    static class MatrixTranspose
    {
        public static void RunThis()
        {
            int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] transpose = new int[cols, rows];

            // Transpose the matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transpose[j, i] = matrix[i, j];  // Swap rows and columns
                }
            }

            // Print the transposed matrix
            Console.WriteLine("Transpose of matrix:");
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(transpose[i, j] + " ");
                }
                Console.WriteLine();
            }
        }                                                
    }    
}
