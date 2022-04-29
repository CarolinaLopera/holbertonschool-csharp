using System;

namespace MyMath {
    /// <sumary> class Matrix </sumary>
    public class Matrix {
        /// <sumary> method to divide a matrix by a number </sumary>
        public static int[,] Divide(int[,] matrix, int num) {
            if (num == 0) {
                Console.WriteLine("Num cannot be 0");
                return null;
            } else if (matrix == null) {
                return null;
            }

            int[,] resultDivide = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    resultDivide[i, j] = matrix[i, j] / num;
                }
            }
            return resultDivide;
        }
    }
}
