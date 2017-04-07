using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalKul;
using CalKul.Operators;
using System.Collections;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class SwapTest
    {
        Swap swap;

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TooFewArgs()
        {
            swap = new Swap();
            swap.Do(new Stack<object>());
        }

        [TestMethod]
        public void SwapSwaps()
        {
            swap = new Swap();
            var stack = new Stack<object>();
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(1, swap.Do(stack));
        }
    }
}
