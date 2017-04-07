using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalKul;
using CalKul.Operators;
using System.Collections;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class MinusTest
    {
        Minus min;

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TooFewArgs()
        {
            min = new Minus();
            min.Do(new Stack<object>());
        }

        [TestMethod]
        public void MinArgs()
        {
            min = new Minus();
            double arg1 = 5;
            double arg2 = 2;
            var stack = new Stack<object>();
            stack.Push(arg1);
            stack.Push(arg2);
            Assert.AreEqual(3.0, min.Do(stack));
        }
    }
}
