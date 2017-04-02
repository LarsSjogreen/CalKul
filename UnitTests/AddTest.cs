using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalKul;
using System.Collections;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class AddTest
    {
        Plus plus;

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TooFewArgs()
        {
            plus = new Plus();
            plus.Do(new Stack<object>());
        }

        [TestMethod]
        public void TwoArgsAdds()
        {
            plus = new Plus();
            var stack = new Stack<object>();
            stack.Push(2.0);
            stack.Push(3.0);
            plus = new Plus();
            Assert.AreEqual(5.0, plus.Do(stack));
        }
    }
}
