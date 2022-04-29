using NUnit.Framework;

namespace Text.Tests {
    [TestFixture]
    public class Tests {
        [TestCase("")]
        [TestCase("level")]
        [TestCase("Racecar")]
        [TestCase("A man, a plan, a canal: Panama?")]
        public void IsTrue(string str) {
            Assert.AreEqual(true, Str.IsPalindrome(str));
        }

        [TestCase("hola")]
        [TestCase("My name is Palindrome")]
        public void IsFalse(string str) {
            Assert.AreEqual(false, Str.IsPalindrome(str));
        }

        [Test]
        public void Type() {
            Assert.AreEqual(false.GetType(), Str.IsPalindrome(":)").GetType());
            Assert.AreNotEqual("false".GetType(), Str.IsPalindrome(":)").GetType());
            Assert.AreNotEqual(1.GetType(), Str.IsPalindrome(":)").GetType());
        }
    }
}
