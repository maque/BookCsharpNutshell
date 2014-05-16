using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CsharpNutShellTests
{
	[TestClass]
	public class NumbersTest
	{
		/*
			short x = 1, y = 1;
			short z = x + y; // Compile-time error
		    short z = (short) (x + y); // OK
		 
		 
			decimal d = −1.23M; // Will not compile without the M suffix.
		 *					about 10 times slower than double
		 *					
		 * 
		 */



		[TestMethod]
		public void ConversionAndRound()
		{

			int intValueShortMaxPlusOne = short.MaxValue + 1;

			long longValue = intValueShortMaxPlusOne;
			Assert.AreEqual(intValueShortMaxPlusOne, longValue);

			short shortValue = (short)intValueShortMaxPlusOne; //owerflow
			Assert.AreEqual(short.MinValue, shortValue);


			float floatValue = 4.5f;
			int intFromFloatValue = (int)floatValue;
			Assert.AreEqual(4, intFromFloatValue);
		}

		[TestMethod]
		public void FloatToInt_BigNumber_LosePrecision()
		{
			int i1 = 100000001;
			float f = i1;
			Assert.AreEqual(100000000, f);
		}

		[TestMethod]
		[ExpectedException(typeof(OverflowException))]
		public void CheckedMul_OverflowException()
		{
			// /checked+ turn on checking each expressions
			// int x = int.MaxValue + 1; // Compile-time error
			// int y = unchecked(int.MaxValue + 1); // No errors
			int a = 1000000;
			int b = 1000000;
			int c = checked(a * b);

		}

		[TestMethod]
		public void CheckedMulUnchecked_NoOverflowException()
		{
			int a = 1000000;
			int b = 1000000;
			int c = 0;
			checked
			{
				//c = a * b; Exception
				unchecked
				{
					c = a * b;
				}
			}
		}

		[TestMethod]
		public void BitWiseOperators()
		{
			Assert.AreEqual(0xfffffff0U, ~0xfU);
			Assert.AreEqual(0xfffffff0U, ~(15U));

			Assert.AreEqual(0xf0 & 0x33, 0x30);
			Assert.AreEqual(0xf0 | 0x33, 0xf3);
			Assert.AreEqual(0xff00 ^ 0x0ff0, 0xf0f0);
			Assert.AreEqual(0x20 << 2, 0x80);
			Assert.AreEqual(0x20 >> 1, 0x10);
		}

		[TestMethod]
		public void HexNumbers()
		{
			Assert.AreEqual(0x7, 7);
			Assert.AreEqual(0x41, 'A');

		}

		[TestMethod]
		public void LiteralNumbers()
		{
			Assert.AreEqual(1000000, 1E06);

			Assert.AreEqual("System.Double", 1.0.GetType().ToString());
			Assert.AreEqual("System.Double", 1D.GetType().ToString());
			Assert.AreEqual("System.Double", 1E06.GetType().ToString());

			Assert.AreEqual("System.Int32", 1.GetType().ToString());
			Assert.AreEqual("System.UInt32", 0xF0000000.GetType().ToString());
			Assert.AreEqual("System.UInt32", 1U.GetType().ToString());

			Assert.AreEqual("System.Int64", 1L.GetType().ToString()); //long
			Assert.AreEqual("System.UInt64", 1UL.GetType().ToString());

			Assert.AreEqual("System.Single", 1.0F.GetType().ToString());

			Assert.AreEqual("System.Decimal", 1M.GetType().ToString());
		}

		[TestMethod]
		public void SpecialFloatValues()
		{

			//This rules apply also to float

			Assert.AreEqual(double.PositiveInfinity, 1.0 / 0.0);
			Assert.AreEqual(double.NegativeInfinity, -1.0 / 0.0);
			Assert.AreEqual(double.NegativeInfinity, 1.0 / -0.0);
			Assert.AreEqual(double.PositiveInfinity, -1.0 / -0.0);

			Assert.AreEqual(double.NaN, -0.0 / -0.0);
			Assert.AreEqual(double.NaN, double.PositiveInfinity - double.PositiveInfinity);
			Assert.AreEqual(double.PositiveInfinity, double.PositiveInfinity - double.NegativeInfinity);
			Assert.AreEqual(double.NegativeInfinity, double.NegativeInfinity - double.PositiveInfinity);

			Assert.AreEqual(float.PositiveInfinity, 1.0f / 0.0f);
			Assert.AreEqual(float.NegativeInfinity, -1.0f / 0.0f);
			Assert.AreEqual(float.NegativeInfinity, 1.0f / -0.0f);
			Assert.AreEqual(float.PositiveInfinity, -1.0f / -0.0f);

			Assert.AreEqual(float.NaN, -0.0f / -0.0f);
			Assert.AreEqual(float.NaN, float.PositiveInfinity - float.PositiveInfinity);
			Assert.AreEqual(float.PositiveInfinity, float.PositiveInfinity - float.NegativeInfinity);
			Assert.AreEqual(float.NegativeInfinity, float.NegativeInfinity - float.PositiveInfinity);

		}

		[TestMethod]
		public void SpecialFloatValues_NanIsNotEqualToNan()
		{
			Assert.IsFalse(0.0 / 0.0 == double.NaN);
			Assert.IsTrue(double.IsNaN(0.0 / 0.0));
			Assert.IsTrue(object.Equals(0.0 / 0.0, double.NaN));
		}

		[TestMethod]
		public void RoundNumberFloatMistakes()
		{
			float floatValueOneSixth = 1f / 6f;
			Assert.AreEqual(1, floatValueOneSixth + floatValueOneSixth + floatValueOneSixth + floatValueOneSixth + floatValueOneSixth + floatValueOneSixth);
			Assert.AreEqual(1, floatValueOneSixth * 6);

			float floatOneTenth = 0.1f;
			float floatOne = 1f;
			Assert.AreNotEqual(9f, floatOneTenth * 10f - floatOne); // 1.490116E-08

			double doubleValueOneSixth = 1d / 6d;
			Assert.AreNotEqual(1, doubleValueOneSixth + doubleValueOneSixth + doubleValueOneSixth + doubleValueOneSixth + doubleValueOneSixth + doubleValueOneSixth);
			Assert.AreEqual(1, doubleValueOneSixth * 6);

			decimal decimalValueOneSixth = 1M / 6M;
			Assert.AreNotEqual(1, decimalValueOneSixth + decimalValueOneSixth + decimalValueOneSixth + decimalValueOneSixth + decimalValueOneSixth + decimalValueOneSixth);
			Assert.AreNotEqual(1, decimalValueOneSixth * 6);

		}
	}
}
