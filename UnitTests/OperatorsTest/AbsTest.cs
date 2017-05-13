using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalKul;
using System.Collections;
using System.Collections.Generic;
using CalKul.Operators;

namespace UnitTests
{
    [TestClass]
    public class AbsTest
    {
        Abs abs;
        [TestInitialize]
        public void Initialize()
        {
            abs = new Abs();
        }

        [TestMethod]
        public void DoesntChangePositiveNums()
        {
            var stack = new Stack<object>();
            stack.Push(10.0);
            Assert.AreEqual(10.0, abs.Do(stack));
        }

        [TestMethod]
        public void MakesNegativePositive()
        {
            var stack = new Stack<object>();
            stack.Push(-10.0);
            Assert.AreEqual(10.0, abs.Do(stack));
        }
    }
}
