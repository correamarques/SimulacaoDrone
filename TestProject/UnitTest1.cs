using Business;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
	[TestClass]
	public class UnitTest1
	{
		#region Invalid tests
		[TestMethod]
		public void Input_Invalid()
		{
			Assert.AreEqual("(999, 999)", Drone.Evaluate("LLL$LNX2NNN"));
		}
		#endregion
		
		#region Simple tests
		[TestMethod]
		public void Input_LLLLNNNN()
		{
			Assert.AreEqual("(4, 4)", Drone.Evaluate("LLLLNNNN"));
		}
		[TestMethod]
		public void Input_OOOSSSS()
		{
			Assert.AreEqual("(-3, -4)", Drone.Evaluate("OOOSSSS"));

		}
		[TestMethod]
		public void Input_OOSOSSOSOOSSSS()
		{
			Assert.AreEqual("(-6, -8)", Drone.Evaluate("OOSOSSOSOOSSSS"));
		}
		#endregion

		[TestMethod]
		public void Input_OOXXSOSXSOSOOXXSSS()
		{
			Assert.AreEqual("(-2, -6)", Drone.Evaluate("OOXXSOSXSOSOOXXSSS"));
		}
		[TestMethod]
		public void Input_OOXXSOSXSOSOOXXSSSX()
		{
			Assert.AreEqual("(-2, -5)", Drone.Evaluate("OOXXSOSXSOSOOXXSSSX"));
		}

	}
}
