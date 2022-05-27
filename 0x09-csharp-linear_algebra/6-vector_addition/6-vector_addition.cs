using System;
using System.Collections.Generic;

/// <sumary> class VectorMath </sumary>
class VectorMath {
    /// <sumary> method Add </sumary>
    public static double[] Add(double[] vector1, double[] vector2) {
        if (vector1.Length != vector2.Length){
            double[] newVector = { -1 };
            return newVector;
        }
        if (vector1.Length == 2) {
            double[] newVector = { vector1[0] + vector2[0], vector1[1] + vector2[1] };
            return newVector;
        }
        if (vector1.Length == 3) {
            double[] newVector = { vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2] + vector2[2] };
            return newVector;
        }
        double[] newVector = { -1 };
        return newVector;
    }
}
