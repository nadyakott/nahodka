using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InputOutputMessages;
using System.Collections.Generic;

namespace Nahodka.Tests
{
    [TestClass]
    public class inputOutputTests
    {
        [TestMethod]
        public void CompareTwoArr_EmptyArrays_0returned()
        {
            List<string> input = null;
            List<string> output = null;
            double expected = 0;

            //InputOutputMessage inputOutput = new InputOutputMessage();
            double actual = InputOutputMessage.CompareTwoArrays(input, output);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CompareTwoArr_EqualArrays_100returned()
        {
            List<string> input = new List<string>() { "", "pug" };
            List<string> output = new List<string>() { "", "pug" };
            double expected = 100;

            //InputOutputMessage inputOutput = new InputOutputMessage();
            double actual = InputOutputMessage.CompareTwoArrays(input, output);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CompareTwoArr_DifferentSizeArr_100returned()
        {

            //InputOutputMessage inputOutput = new InputOutputMessage();
            List<string> input = new List<string>() { "", "pug", "black" };
            List<string> output = new List<string>() { "", "pug" };

            var expected = 66.666666666;
            double tolerance = .001;

            double actual = InputOutputMessage.CompareTwoArrays(input, output);
            Assert.AreEqual(expected, actual,tolerance);
        }
        [TestMethod]
        public void CompareTwoArr_DifferentValues_100returned()
        {
            //InputOutputMessage inputOutput = new InputOutputMessage();
            List<string> input = new List<string>() {"pp" };
            List<string> output = new List<string>() { "p" };

            var expected = 0;
            //double tolerance = .001;

            double actual = InputOutputMessage.CompareTwoArrays(input, output);
            Assert.AreEqual(expected, actual);
        }
    }
}
