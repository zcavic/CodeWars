using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars.Algorithms;
using NUnit.Framework;

namespace UnitTests.Algorithms
{
	[TestFixture]
	public class CartCodeTest
	{
		[Test]
		public void CartTest()
		{
			int res = Result.foo(new List<string>() { "apple apple", "banana anything banana" }, new List<string>() { "orange apple apple banana orange banana" });
			Assert.AreEqual(res, 1);
		}
	}
}
