using System;

class Program {
    static void Main(string[] args) {
        int[,] matrix = {
                            {0, 0, 0, 0, 0},
                            {0, 0, 0, 0, 0},
                            {0, 0, 1, 0, 0},
                            {0, 0, 0, 0, 0},
                            {0, 0, 0, 0, 0}
                        };

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
                if (j != matrix.GetLength(1) - 1) {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
