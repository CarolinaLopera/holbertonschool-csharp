using NUnit.Framework;

namespace MyMath.Tests {
    [TestFixture]
    public class Tests {

        [Test]
        public void MatrixRigth() {
            int[,] matrix = new int[,] { {1, 2}, {3, 4} };
            int[,] matrix2 = new int[,] { {2, 4}, {6, 8} };
            int[,] matrix3 = new int[,] { {3, 6}, {9, 12} };
            Assert.AreEqual(matrix, Matrix.Divide(matrix, 1));
            Assert.AreEqual(matrix, Matrix.Divide(matrix2, 2));
            Assert.AreEqual(matrix, Matrix.Divide(matrix3, 3));
        }

        [Test]
        public void IsNull() {
            int[,] matrix = new int[,] { {1, 2}, {3, 4} };
            Assert.AreEqual(null, Matrix.Divide(matrix, 0));
            Assert.AreEqual(null, Matrix.Divide(null, 4));
        }
    }
}
