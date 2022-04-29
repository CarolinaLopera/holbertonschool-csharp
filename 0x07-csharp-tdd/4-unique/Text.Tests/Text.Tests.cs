using NUnit.Framework;

namespace Text.Tests {
    [TestFixture]
    public class Tests {
        [TestCase(3, "holaholberton")]
        [TestCase(0, "thisisuniquechar")]
        public void Index(int index, string str) {
            Assert.AreEqual(index, Str.UniqueChar(str));
        }

        [Test]
        public void Empty() {
            Assert.AreEqual(-1, Str.UniqueChar(""));
        }
        
        [Test]
        public void NoUnique() {
            Assert.AreEqual(-1, Str.UniqueChar("vicvic"));
        }
    }
}
