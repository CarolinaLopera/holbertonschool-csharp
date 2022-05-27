using System;
using System.Collections.Generic;

///<summary> class VectorMath </summary>
class VectorMath {
    ///<summary> method Multiply </summary>
    public static double[] Multiply(double[] vector, double scalar) {
        if (vector.Length == 2) {
            double[] result = new double[] { vector[0] * scalar, vector[1] * scalar };
            return result;
        } else if (vector.Length == 3) {
            double[] result = new double[] { vector[0] * scalar, vector[1] * scalar, vector[2] * scalar };
            return result;
        }
        return -1;
    }
}