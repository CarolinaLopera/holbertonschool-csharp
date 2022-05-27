using System;
using System.Collections.Generic;

///<summary> class VectorMath </summary>
class VectorMath {
    ///<summary> method Multiply </summary>
    public static double[] Multiply(double[] vector, double scalar) {
        if (vector.Length == 2) {
            double[] twoD = new double[] { vector[0] * scalar, vector[1] * scalar };
            return twoD;
        } else if (vector.Length == 3) {
            double[] threeD = new double[] { vector[0] * scalar, vector[1] * scalar, vector[2] * scalar }  ;
            return threeD;
        }
        double[] bad = new double[] { -1 };
        return bad;
    }
}