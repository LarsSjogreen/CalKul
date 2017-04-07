using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalKul;
using CalKul.Operators;
using System.Collections;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class SinTest
    {
        Sin sin;

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TooFewArgs()
        {
            sin = new Sin();
            sin.Do(new Stack<object>());
        }

        [TestMethod]
        public void SinArg()
        {
            sin = new Sin();
            double arg = 123;
            var stack = new Stack<object>();
            stack.Push(arg);
            
            Assert.IsTrue(0.000001 > Math.Abs((double)(sin.Do(stack)) - (-0.459903490689591)));
        }
    }
}
