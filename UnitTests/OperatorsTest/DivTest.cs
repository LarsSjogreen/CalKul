using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalKul;
using CalKul.Operators;
using System.Collections;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class DivTest
    {
        Div div;
        [TestInitialize]
        public void Initialize()
        {
            div = new Div();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TooFewArgs()
        {
            div.Do(new Stack<object>());
        }

        [TestMethod]
        public void DivTwoArgs()
        {
            var stack = new Stack<object>();
            stack.Push(4.0);
            stack.Push(2.0);
            Assert.AreEqual(2.0, div.Do(stack));
        }
    }
}