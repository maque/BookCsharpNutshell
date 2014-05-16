using System;
using System.Text;

namespace CsharpNutShell.LanguageBasics
{
	class StackAndHeap
	{
		/// <summary>
		/// This method is recursive, meaning that it calls itself. Each time the method is entered,
		///a new int is allocated on the stack, and each time the method exits, the int is
		///deallocated.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static int Factorial(int x)
		{
			if (x == 0) return 1;
			return x * Factorial(x - 1);
		}

		static void HeapBlockOfMemoryWhereObjectsReside()
		{

			StringBuilder ref1 = new StringBuilder("object1");
			Console.WriteLine(ref1);
			// The StringBuilder referenced by ref1 is now eligible for GC.
			StringBuilder ref2 = new StringBuilder("object2");
			StringBuilder ref3 = ref2;
			// The StringBuilder referenced by ref2 is NOT yet eligible for GC.
			Console.WriteLine(ref3); // object2
		}
	}
}
