using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalKul;
using CalKul.Operators;
using System.Collections;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class CosTest
    {
        Cos cos;

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TooFewArgs()
        {
            cos = new Cos();
            cos.Do(new Stack<object>());
        }

        [TestMethod]
        public void CosArg()
        {
            cos = new Cos();
            double arg = 123;
            var stack = new Stack<object>();
            stack.Push(arg);
            Assert.IsTrue(0.000001 > Math.Abs((double)(cos.Do(stack))- (-0.887968906691855)));
        }
    }
}
