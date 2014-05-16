
namespace CsharpNutShell.LanguageBasics
{
	//Value type
	public struct TestStruct
	{
		public int X;
		public void ChangeXValue(TestStruct objectToChange, int newX)
		{
			objectToChange.X = newX;
		}

		public void ChangeInt(int x, int newX)
		{
			x = newX;
		}
	}

	//Reference type
	public class TestClass
	{
		public int X;
		public void ChangeXValue(TestClass objectToChange, int newX)
		{
			objectToChange.X = 10;
		}

		public void TestOut(out int x)
		{
			x = 2; //must be assigned
		}

		public void ChangeInt(ref int objectToChange, int newX)
		{
			objectToChange = newX;
		}

		public void ChangeIntOut(out int objectToChange, int newX)
		{
			objectToChange = newX;
		}

		public int Sum(params int[] intsToSum)
		{
			int sum = 0;
			for (int i = 0; i < intsToSum.Length; i++)
				sum += intsToSum[i]; // Increase sum by ints[i]
			return sum;

		}

		public void OptionalParameter(int x = 1) { }

		public void namedParameters()
		{
			//Foo(x: 1, y: 2);
			//Foo(y: 2, x: 1);
			int x = 4;
			x *= 2; // equivalent to x = x * 2
			x <<= 1; // equivalent to x = x << 1

		}
	}
}
