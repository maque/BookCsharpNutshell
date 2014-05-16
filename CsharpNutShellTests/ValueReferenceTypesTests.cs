using CsharpNutShell.LanguageBasics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsharpNutShellTests
{

	struct A { byte b; long l; } //consumes 16 bytes

	[TestClass]
	public class ValueReferenceTypesTests
	{
		[TestMethod]
		public void ChangeObject_PassStruct_StructIsNotChanged()
		{
			var testStruct = new TestStruct { X = 5 };
			testStruct.ChangeXValue(testStruct, 10);
			Assert.AreEqual(5, testStruct.X);
			//compile-time error testStruct = null;

		}

		[TestMethod]
		public void ChangeObject_PassClass_ClassIsChanged()
		{
			var testClass = new TestClass { X = 5 };
			testClass.ChangeXValue(testClass, 10);
			Assert.AreEqual(10, testClass.X);
			testClass = null;
		}

		[TestMethod]
		public void ChangeInt_IntIsNotChanged()
		{
			var testStruct = new TestStruct();
			int x = 10;
			testStruct.ChangeInt(x, 11);
			Assert.AreNotEqual(11, x);
		}

		[TestMethod]
		public void ChangeIntRef_IntIsChanged()
		{
			var testClass = new TestClass();

			int x = 10;
			testClass.ChangeInt(ref x, 11);
			Assert.AreEqual(11, x);
		}

		[TestMethod]
		public void ChangeIntOut_IntIsChanged()
		{
			var testClass = new TestClass();

			int x = 10;
			testClass.ChangeIntOut(out x, 11);
			Assert.AreEqual(11, x);
		}

		[TestMethod]
		public void ReferenceTypeEquility()
		{
			var testClass = new TestClass { X = 3 };
			var testClass2 = new TestClass { X = 3 };
			Assert.AreNotEqual(testClass, testClass2);
			testClass2 = testClass;
			Assert.AreEqual(testClass, testClass2);
		}

	}


}
