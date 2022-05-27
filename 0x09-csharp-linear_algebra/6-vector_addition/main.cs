using System;

class Program
{
    static void Main()
    {
        double[] matrix = { -9, 4 };
        double[] matrix2 = { 2, 2 };
        double[] matrix1 = VectorMath.Add(matrix, matrix2);
        foreach (var item in matrix1)
        {
            Console.WriteLine(item);
        }
    }
}