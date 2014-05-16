
namespace CsharpNutShell.LanguageBasics
{
	public class StringCharacters
	{
		public static void VerbatimStringVsBackslash()
		{
			string verbatim = @"This\'is\\verbatim
				SecondLine";

			string backslash = "This\'is\\backslash\n\rSecondLine";
		}
	}
}
