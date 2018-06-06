using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EvilFizzBuzz
{
    [TestClass]
    public class CommaDelimSeq_Tests
    {
        [TestMethod]
        public void ReturnsCommaDelimitedSequence()
        {
            List<string> input = new List<string>() { "Apple", "2", "Fred" };
            string expected = "Apple,2,Fred";
            string result = GenerateCommaDelimSeq.Delimit(input);
            Assert.AreEqual(expected, result);
        }
    }
}
