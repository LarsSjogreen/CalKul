using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalKul;
using CalKul.Operators;
using System.Collections;
using System.Collections.Generic;

namespace UnitTests
{
	[TestClass]
	public class MultTest
	{
		Mult mult;
		[TestInitialize]
		public void Initialize()
		{
			mult = new Mult();
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TooFewArgs()
		{
			mult.Do(new Stack<object>());
		}

		[TestMethod]
		public void MultTwoArgs()
		{
			var stack = new Stack<object>();
			stack.Push(2.0);
			stack.Push(3.0);
			Assert.AreEqual(6.0, mult.Do(stack));
		}
	}
}
