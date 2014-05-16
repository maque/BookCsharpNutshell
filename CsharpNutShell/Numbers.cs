using System;

namespace CsharpNutShell
{
	public class Numbers
	{
		public static void ExplicitAndImplicitConversion()
		{

		}

		public static void WriteNumericValues()
		{

			Console.WriteLine("{0} size: {3} max: {1} min: {2}", "sbyte", sbyte.MaxValue, sbyte.MinValue, sizeof(sbyte));
			Console.WriteLine("{0} size: {3} max: {1} min: {2}", "byte", byte.MaxValue, byte.MinValue, sizeof(byte));

			Console.WriteLine("{0} size: {3} max: {1} min: {2}", "short", short.MaxValue, short.MinValue, sizeof(short));
			Console.WriteLine("{0} size: {3} max: {1} min: {2}", "ushort", ushort.MaxValue, ushort.MinValue, sizeof(ushort));

			Console.WriteLine("{0} size: {3} max: {1} min: {2}", "int", int.MaxValue, int.MinValue, sizeof(int));
			Console.WriteLine("{0} size: {3} max: {1} min: {2}", "uint", uint.MaxValue, uint.MinValue, sizeof(uint));

			Console.WriteLine("{0} size: {3} max: {1} min: {2}", "long", long.MaxValue, long.MinValue, sizeof(long));
			Console.WriteLine("{0} size: {3} max: {1} min: {2}", "ulong", ulong.MaxValue, ulong.MinValue, sizeof(ulong));

			Console.WriteLine("{0} size: {3} max: {1} min: {2}", "float", float.MaxValue, float.MinValue, sizeof(float));
			Console.WriteLine("{0} size: {3} max: {1} min: {2}", "double", double.MaxValue, double.MinValue, sizeof(double));
			Console.WriteLine("{0} size: {3} max: {1} min: {2}", "decimal", decimal.MaxValue, decimal.MinValue, sizeof(decimal));

		}
	}
}
