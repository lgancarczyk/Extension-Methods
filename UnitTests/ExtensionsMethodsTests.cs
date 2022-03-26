using Metody_Rozszerzajace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ExtensionsMethodsTests
    {
        [TestMethod]
        public void WithoutVowelsTest()
        {
            string str = "test string";
            string expected = "tst strng";
            Assert.AreEqual(expected, str.WithoutVowels(), "Output contains vowels!");
        }

        [TestMethod]
        public void IsNumericTrueResult() 
        {
            string str = "20";
            Assert.AreEqual(true, str.IsNumeric(), "Result should be true");
        }

        [TestMethod]
        public void IsNumericFalseResult()
        {
            string str = "20.01";
            Assert.AreEqual(false, str.IsNumeric(), "Result should be false");
        }
    }
}
