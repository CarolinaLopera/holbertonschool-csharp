using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests {
    [TestFixture]
    public class Tests {
        [Test]
        public void RigthValue() {
            List<int> list = new List<int>() {1, 2, 3, 4, 5};
            List<int> list2 = new List<int>() {2, 4, 5, 8, 10};
            List<int> list3 = new List<int>() {200, 99, 98, 97, 96};
            Assert.AreEqual(5, Operations.Max(list));
            Assert.AreEqual(10, Operations.Max(list2));
            Assert.AreEqual(200, Operations.Max(list3));
        }

        [Test]
        public void Type() {
            List<int> list = new List<int>() {1, 2, 8, 4, 5};
            Assert.AreEqual(8.GetType(), Operations.Max(list).GetType());
            Assert.AreNotEqual("8".GetType(), Operations.Max(list).GetType());
            Assert.AreNotEqual(true.GetType(), Operations.Max(list).GetType());
        }

        [Test]
        public void Empty() {
            List<int> list = new List<int>();
            Assert.AreEqual(0, Operations.Max(list));
        }

        [Test]
        public void Negative() {
            List<int> list = new List<int>() {-10, -20, -38, -5, -24};
            Assert.AreEqual(-5, Operations.Max(list));
        }
    }
}
