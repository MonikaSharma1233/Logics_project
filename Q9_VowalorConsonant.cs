using System;

public class Q9_VowalorConsonant
{
	public static void Checkchar_VorC()
	{
		Console.WriteLine("Enter the Character:");
		Char character=Convert.ToChar(Console.ReadLine());
		if(character=='a' || character == 'e' || character == 'i' || character == 'o' || character == 'u' || character == 'A' || character == 'E' || character == 'I' || character == 'O' || character == 'U' )
		{
			Console.WriteLine("CHARCTER IS VOWAL.");
		}
		else if(character>='a' && character<='z' || character>='A' && character<='Z')
		{
			Console.WriteLine("CHARCTER IS CONSONANT.");
		}
		else
		{
			Console.WriteLine("INVALID INPUT!!!");
		}
	}
}
