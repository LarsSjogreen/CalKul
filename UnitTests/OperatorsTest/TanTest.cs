using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalKul;
using CalKul.Operators;
using System.Collections;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class TanTest
    {
        Tan tan;

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TooFewArgs()
        {
            tan = new Tan();
            tan.Do(new Stack<object>());
        }

        [TestMethod]
        public void TanArg()
        {
            tan = new Tan();
            double arg = 123;
            var stack = new Stack<object>();
            stack.Push(arg);
            Assert.IsTrue(0.000001 > Math.Abs((double)(tan.Do(stack)) - (0.517927471585655)));
        }
    }
}
