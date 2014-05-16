using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsharpNutShellTests
{
	[TestClass]
	public class StringCharactersTests
	{
		[TestMethod]
		public void Characters()
		{
			Assert.AreEqual('\'', 0x27); //single quote
			Assert.AreEqual('\"', 0x22); //double quote
			Assert.AreEqual('\\', 0x5C); //backslassh
			Assert.AreEqual('\0', 0x0); //NUll

			Assert.AreEqual('\a', 0x7); //alert
			Assert.AreEqual('\b', 0x8); //Nbackspace
			Assert.AreEqual('\f', 0xc); //form feed
			Assert.AreEqual('\n', 0xa); //new line
			Assert.AreEqual('\r', 0xD); //carriage return
			Assert.AreEqual('\t', 0x9); //horizontal tab
			Assert.AreEqual('\v', 0xb); //vertical tab
		}

		[TestMethod]
		public void VerbatimStringVsBackslash()
		{

			string verbatim = @"This\'is\\it";
			string backslash = "This\'is\\it";

			Assert.AreNotEqual(verbatim, backslash);
			Assert.AreEqual(@"This'is\it", backslash);
		}

		[TestMethod]
		public void StringConcatenation()
		{
			Assert.AreEqual("a" + "a", "aa");
		}
	}
}
