using NUnit.Framework;

namespace Text.Tests {
    [TestFixture]
    public class Tests {
        [Test]
        public void NumRigth() {
            Assert.AreEqual(1, Str.CamelCase("one"));
            Assert.AreEqual(2, Str.CamelCase("helloWorld"));
            Assert.AreEqual(4, Str.CamelCase("myNameIsDev"));
        }

        [Test]
        public void Empty() {
            Assert.AreEqual(0, Str.CamelCase(""));
        }

        [Test]
        public void Type() {
            Assert.AreEqual(3.GetType(), Str.CamelCase("oneTwoThree").GetType());
        }
    }
}
