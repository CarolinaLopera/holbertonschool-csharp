using System;
using System.Collections.Generic;

///<summary> class VectorMath </summary>
class VectorMath {
    ///<summary> method Add </summary>
    public static double[] Add(double[] vector1, double[] vector2) {
        double[] bad = new double[] { -1 };
        if (vector1.Length != vector2.Length){
            return bad;
        }

        if (vector1.Length == 2) {
            double[] twoD = new double[] { vector1[0] + vector2[0], vector1[1] + vector2[1] };
            return (twoD);
        }
        if (vector1.Length == 3) {
            double[] threeD = { vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2] + vector2[2] };
            return threeD;
        }
        return bad;
    }
}
