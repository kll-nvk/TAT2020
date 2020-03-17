using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1._2;

namespace DEV_1._2Tests
{
    [TestClass]
    public class NumberConverterTests
    {
        [TestMethod]
        public void ConvertNumber_To16BaseSystemTest()
        {

            NumberConverter numberConverter = new NumberConverter();
            string  actual = numberConverter.ConvertNumber(2600, 16);
            string expected = "A28";

            Assert.AreEqual(actual, expected);

        }

        [TestMethod]

        public void ConvertNumber_To2BaseSystemTest()
        {

            NumberConverter numberConverter = new NumberConverter();
            string actual = numberConverter.ConvertNumber(2600, 2);
            string expected = "101000101000";

            Assert.AreEqual(actual, expected);

        }

        [TestMethod]

        public void ConvertNumber_To20BaseSystemTest()
        {

            NumberConverter numberConverter = new NumberConverter();
            string actual = numberConverter.ConvertNumber(2600, 20);
            string expected = "6A0";

            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        [DataRow(0u,2u)]
        [DataRow(0u,16u)]
        [DataRow(0u,20u)]

        public void ConvertNumber_ConvertZerotTest(uint number, uint numberSystem)
        {

            NumberConverter numberConverter = new NumberConverter();
            string actual = numberConverter.ConvertNumber(number,numberSystem);
            string expected = "0";
       
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [DataRow(69u,21u)]
        [DataRow(69u,1u)]

        public void ConvertNumber_ConvertToUnExpectedNumberSystem(uint number, uint numberSystem)
        {
            NumberConverter numberConverter = new NumberConverter();
            Assert.ThrowsException<ArgumentException>(delegate { numberConverter.ConvertNumber(number, numberSystem); });

        }



    }
}
