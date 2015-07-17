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
		public void Input_XOOXXSOSXSOSOOXXSSS()
		{// First char can't be X
			Assert.AreEqual("(999, 999)", Drone.Evaluate("XOOXXSOSXSOSOOXXSSS"));
		}
		[TestMethod]
		public void Input_OOXXSOSXSOSOOXXSSS()
		{
			Assert.AreEqual("(-6, -2)", Drone.Evaluate("OOXXSOSXSOSOOXXSSS"));
		}
		[TestMethod]
		public void Input_OOXXXSOSXSOSOOXXSSS()
		{// Não pode haver maior quantidade de X do que a letra anterior
			Assert.AreEqual("(999, 999)", Drone.Evaluate("OOXXXSOSXSOSOOXXSSS"));
		}
		[TestMethod]
		public void Input_OOXXSOSXSOSOOXXSSSX()
		{
			Assert.AreEqual("(-5, -2)", Drone.Evaluate("OOXXSOSXSOSOOXXSSSX"));
		}

		[TestMethod]
		public void Input_OOXXXSOSX2SOSOOXXSSS()
		{// Não pode existir número após o X
			Assert.AreEqual("(999, 999)", Drone.Evaluate("OOXXXSOSX2SOSOOXXSSS"));
		}
	}
}
