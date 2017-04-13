using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalKul;
using CalKul.Operators;
using System.Collections;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class XrootTest
    {
        Xroot xroot;

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TooFewArgs()
        {
            xroot = new Xroot();
            xroot.Do(new Stack<object>());
        }

        [TestMethod]
        public void XrootArgs()
        {
            xroot = new Xroot();
            double arg1 = 10;
            double arg2 = 1;
            var stack = new Stack<object>();
            stack.Push(arg1);
            stack.Push(arg2);
            Assert.AreEqual(10.0, xroot.Do(stack));
        }
    }
}
