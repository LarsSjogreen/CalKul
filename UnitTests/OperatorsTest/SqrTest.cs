using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalKul;
using System.Collections;
using System.Collections.Generic;
using CalKul.Operators;

namespace UnitTests
{
    [TestClass]
    public class SqrTest
    {
        Square sqr;

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TooFewArgs()
        {
            sqr = new Square();
            sqr.Do(new Stack<object>());
        }

        [TestMethod]
        public void SquareArg()
        {
            sqr = new Square();
            double arg = 10;
            var stack = new Stack<object>();
            stack.Push(arg);
            Assert.AreEqual(100.0, sqr.Do(stack));
        }
    }
}
