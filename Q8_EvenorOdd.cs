using System;

public class Q8_EnvenorOdd
{
	public static void Check_EvenOdd()
	{
		Console.WriteLine("Enter the Number to check number is even or odd:");
		int numb=Convert.ToInt32(Console.ReadLine());
		if(numb%2 ==0 )
		{
			Console.WriteLine("Number is Even.");
		}
		else
		{
			Console.WriteLine("Number is Odd.");
		}
	}
}
