using System;
using DEV_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringAnalizerTest
{
    [TestClass]
    public class StringAnalizerTests
    {
        /// <summary>
        /// Test which check repeating symbols sequence 
        /// </summary>
        [TestMethod]
        [DataRow("AaAqwe",3)]
        [DataRow("aaaqwe",3)]
        [DataRow("AAAqwe",3)]
        [DataRow("qweAAA",3)]
        [DataRow("qweAaA",3)]
        [DataRow("qweaaa",3)]
        [DataRow("qweAAAqwe",3)]
        [DataRow("qweAaAqwe",3)]
        [DataRow("qweaaaqwe",3)]
        [DataRow("  ",2)]
        [DataRow("",0)]
        [DataRow(null,0)]
        [DataRow("!@@#$%^&*",2)]

        public void CountOfRepeatingSymbolsSequence_Test(string word, int expected)
        {
            StringAnalizer stringAnalizer = new StringAnalizer();
            int actual = stringAnalizer.CountOfRepeatingSymbolsSequence(word);

            Assert.AreEqual(expected, actual);
  
            
        }

        /// <summary>
        /// Test which check non repeating symbols sequence 
        /// </summary>
        [TestMethod]
        [DataRow("AaAqwe", 4)]
        [DataRow("aaaqwe", 4)]
        [DataRow("AAAqwe", 4)]
        [DataRow("qweAAA", 4)]
        [DataRow("qweAaA", 4)]
        [DataRow("qweaaa", 4)]
        [DataRow("qweAAAqwe", 4)]
        [DataRow("qweAaAqwe", 4)]
        [DataRow("qweaaaqwe", 4)]
        [DataRow("  ", 1)]
        [DataRow("", 0)]
        [DataRow(null,0)]
        [DataRow("!@@#$%^&*", 7)]

        public void CountOfNonRepeatingSymbolsSequence_Test(string word, int expected)
        {
            StringAnalizer stringAnalizer = new StringAnalizer();
            int actual = stringAnalizer.CountOfNonRepeatingSymbolsSequence(word);

            Assert.AreEqual(expected, actual);


        }



    }
}
