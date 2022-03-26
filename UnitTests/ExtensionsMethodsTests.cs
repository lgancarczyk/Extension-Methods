using Metody_Rozszerzajace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ExtensionsMethodsTests
    {
        [TestMethod]
        public void WithoutVowels()
        {
            string str = "test string";
            string expected = "tst strng";
            Assert.AreEqual(expected, str.WithoutVowels(), "Output contains vowels!");
        }
    }
}
