using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Matrix
{
    internal class RotateProblem
    {
        public static void Rotate(int[][] matrix)
        {
            // difine second diagonal

            int size = matrix.Length;

            // Loop through each row
            for (int row = 0; row < size; row++)
            {
                // Loop through columns that are BEFORE the secondary diagonal
                // Secondary diagonal index for this row is: size - 1 - row
                for (int col = 0; col < size - 1 - row; col++)
                {
                    // Current cell
                    int currentRow = row;
                    int currentCol = col;

                    // Mirrored cell across the secondary diagonal
                    int mirroredRow = size - 1 - col;
                    int mirroredCol = size - 1 - row;

                    // Swap the two values
                    int temp = matrix[currentRow][currentCol];
                    matrix[currentRow][currentCol] = matrix[mirroredRow][mirroredCol];
                    matrix[mirroredRow][mirroredCol] = temp;
                }
            }
            // swap around mid row

            for (int row = 0; row < matrix.Length / 2; row++)
            {
                var currentRow = row;
                var reversedRow = matrix.Length - 1 - row;

                for (int i = 0; i < matrix.Length; i++)
                {
                    var temp = 0;

                    var currentValue = matrix[currentRow][i];
                    var reversedValue = matrix[reversedRow][i];

                    temp = currentValue;
                    matrix[currentRow][i] = reversedValue;
                    matrix[reversedRow][i] = temp;
                }

            }

        }
    }
}
