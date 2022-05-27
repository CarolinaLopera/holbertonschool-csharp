using System;

/// <summary> class VectorMath </summary>
class VectorMath {
    /// <summary> method Magnitude </summary>
    public static double Magnitude(double[] vector) {
        if (vector.Length == 2) {
            double add = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2);
            return (Math.Round(Math.Sqrt(add), 2));
        } else if (vector.Length == 3) {
            double add = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2);
            return (Math.Round(Math.Sqrt(add), 2));
        }
        return -1;
    }
}
