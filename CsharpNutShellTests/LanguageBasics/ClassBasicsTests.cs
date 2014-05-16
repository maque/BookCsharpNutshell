using CsharpNutShell.LanguageBasics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CsharpNutShellTests.LanguageBasics
{

	[TestClass]
	public class ClassBasicsTests
	{
		[TestMethod]
		public void StaticCountIsIncremententEachTime()
		{
			var firstObject = new ClassBasics();

			Assert.AreEqual(1, ClassBasics.Count);

			var secondObject = new ClassBasics();

			Assert.AreEqual(2, ClassBasics.Count);
		}

		[TestMethod]
		public void TestOutWithoutOut()
		{
			var tclass = new TestClass();
			int x = 1;
			tclass.TestOut(out x);
		}
	}
}
