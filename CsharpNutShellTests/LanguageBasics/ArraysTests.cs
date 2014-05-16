using CsharpNutShell.LanguageBasics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CsharpNutShellTests.LanguageBasics
{
	[TestClass]
	public class ArraysTests
	{
		[TestMethod]
		public void OneDimensionArray()
		{
			int[] array = null; //array is reference type

			array = new int[5];
			array[0] = 1;
			array[1] = 2;

			Assert.AreEqual(5, array.Length);
			Assert.AreEqual(1, array[0]);
			Assert.AreEqual(0, array[3]);

		}

		[TestMethod]
		[ExpectedException(typeof(IndexOutOfRangeException))]
		public void OneDimensionArray_AccesingIndexOutOfRange_IndexOutOfRangeException()
		{
			int[] array = new int[5];
			array[5] = 1;
		}

		[TestMethod]
		public void CreateArrayWithStruct_FieldAreEvaluated()
		{
			TestStruct[] array = new TestStruct[5];
			Assert.AreEqual(0, array[4].X);
		}

		[TestMethod]
		[ExpectedException(typeof(NullReferenceException))]
		public void CreateArrayWithClass_FieldAreEvaluated()
		{
			TestClass[] array = new TestClass[5];
			Assert.AreEqual(0, array[4].X);
		}

		[TestMethod]
		public void RectangularArrays()
		{
			int[,] matrix = new int[3, 3];
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = i * 3 + j;
				}
			}

			Assert.AreEqual(8, matrix[2, 2]);
		}

		[TestMethod]
		public void JaggedArrays()
		{
			int[][] matrix = new int[3][];
			for (int i = 0; i < matrix.Length; i++)
			{
				matrix[i] = new int[i + 3]; // Create inner array
				for (int j = 0; j < matrix[i].Length; j++)
					matrix[i][j] = i * 3 + j;
			}

			Assert.AreEqual(9, matrix[2][3]);
		}
	}
}
