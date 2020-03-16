using System;
using DEV_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringAnalizerTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void IsNumberOfRepeatingSymbolsTest()
        {
            StringAnalizer stringAnalizer = new StringAnalizer();
            int actual = 3;
            int excepted = stringAnalizer.NumberOfRepeatingSymbols("qweqqq");

            Assert.AreEqual(actual, excepted);
            
        }

        [TestMethod]
        public void IsNumberOfNonRepeatingSymbolsTest()
        {
            StringAnalizer stringAnalizer = new StringAnalizer();
            int actual = 3;
            int excepted = stringAnalizer.NumberOfNonRepeatingSymbols ("qqqqwe");

            Assert.AreEqual(actual, excepted);

        }

        [TestMethod]
        public void IsNumberOfSameRepeatingSymbolsTest()
        {
            StringAnalizer stringAnalizer = new StringAnalizer();
            int actual = 6;
            int excepted = stringAnalizer.NumberOfRepeatingSymbols("qqqqqq");

            Assert.AreEqual(actual, excepted);

        }

        [TestMethod]
        public void IsNumberOfSameNonRepeatingSymbolsTest()
        {
            StringAnalizer stringAnalizer = new StringAnalizer();
            int actual = 1;
            int excepted = stringAnalizer.NumberOfNonRepeatingSymbols("qqqqqq");

            Assert.AreEqual(actual, excepted);

        }

        [TestMethod]

        public void NonRepeatingSymbolsEmptyStringTest()
        {

            StringAnalizer stringAnalizer = new StringAnalizer();
            int actual = 0;
            int excepted = stringAnalizer.NumberOfNonRepeatingSymbols("");

            Assert.AreEqual(actual, excepted);

        }

        [TestMethod]

        public void RepeatingSymbolsEmptyStringTest()
        {

            StringAnalizer stringAnalizer = new StringAnalizer();
            int actual = 0;
            int excepted = stringAnalizer.NumberOfRepeatingSymbols("");

            Assert.AreEqual(actual, excepted);

        }

        [TestMethod]
        public void NullNonRepeatingSymbTest()
        {

            StringAnalizer stringAnalizer = new StringAnalizer();
            int actual = 0;
            int excepted = stringAnalizer.NumberOfRepeatingSymbols(null);

            Assert.AreEqual(actual, excepted);

        }

        [TestMethod]

        public void NullRepeatingSymbTest()
        {

            StringAnalizer stringAnalizer = new StringAnalizer();
            int actual = 0;
            int excepted = stringAnalizer.NumberOfRepeatingSymbols(null);

            Assert.AreEqual(actual, excepted);

        }


    }
}
