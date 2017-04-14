using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalKul;
using System.Collections;
using System.Collections.Generic;
using CalKul.Operators;

namespace UnitTests
{
    [TestClass]
    public class AddTest
    {
        Plus plus;
        [TestInitialize]
        public void Initialize()
        {
            plus = new Plus();
        }

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
            var stack = new Stack<object>();
            stack.Push(2.0);
            stack.Push(3.0);
            Assert.AreEqual(5.0, plus.Do(stack));
        }

        [TestMethod]
        public void AddStrings()
        {
            var stack = new Stack<object>();
            stack.Push("Foo");
            stack.Push("Bar");
            Assert.AreEqual("FooBar", plus.Do(stack));
        }
    }
}
