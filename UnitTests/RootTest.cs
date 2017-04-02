using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalKul;
using System.Collections;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class RootTest
    {
        Root root;

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TooFewArgs()
        {
            root = new Root();
            root.Do(new Stack<object>());
        }

        [TestMethod]
        public void RootArg()
        {
            root = new Root();
            var stack = new Stack<object>();
            stack.Push(100);
            Assert.AreEqual(10, (double)root.Do(stack));
        }
    }
}
