
using System;

namespace CsharpNutShell
{
	/// <summary>
	/// Compilation
	/// Libraray: csc /target:library MyFirstProgram.cs
	/// APP: csc  MyFirstProgram.cs
	///  for boolean BitArray
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			HelloWorld();

			//Operator Table
			//Types table

			Console.Read();
		}

		static void HelloWorld()
		{
			Console.WriteLine("Hello world!");
		}
	}

	//Conflict avoided by using '@'
	class @class
	{
		public int ImUsingKeywords()
		{
			int @int;
			//Console.WriteLine(x); // Compile-time error
			@int = 2;
			return @int;
		}
	}
}
