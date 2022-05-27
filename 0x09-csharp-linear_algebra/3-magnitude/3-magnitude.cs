using System;

/// <sumary> class VectorMath </sumary>
class VectorMath {
    /// <sumary> method Magnitude </sumary>
    public static double Magnitude(double[] vector) {
        if (vector.Length == 2) {
            double add = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2);
            double root = Math.Sqrt(add);
            double result = Math.Round(root);
            return result;
        }
        if (vector.Length == 3) {
            double add = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2);
            double root = Math.Sqrt(add);
            double result = Math.Round(root);
            return result;
        }
        return -1;
    }
}
