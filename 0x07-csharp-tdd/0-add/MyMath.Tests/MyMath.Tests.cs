using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(5, 3, 8)]
        [TestCase(8, 9, 17)]
        [TestCase(84, 4, 88)]
        [TestCase(42, 36, 78)]
        public void Positives(int a, int b, int c) {
            Assert.AreEqual(c, Operations.Add(a, b));
        }

        [Test]
        public void Negatives() {
            Assert.AreEqual(-35, Operations.Add(-30, -5));
        }

        [Test]
        public void PosAndNeg() {
            Assert.AreEqual(3, Operations.Add(8, -5));
        }

        [Test]
        public void IntegerBig() {
            Assert.AreEqual(89100, Operations.Add(10100, 79000));
        }

        [Test]
        public void Type() {
            Assert.AreEqual(20.GetType(), Operations.Add(10, 10).GetType());
            Assert.AreNotEqual("20".GetType(), Operations.Add(10, 10).GetType());
            Assert.AreNotEqual(true.GetType(), Operations.Add(10, 10).GetType());
        }
    }
}
