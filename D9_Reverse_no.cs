using System;

public class D9_Reverse_no
{
	public static void Get_Reverse()
	{
		Console.WriteLine("Enter the number to reverse : ");
		int num=Convert.ToInt32(Console.ReadLine());
		int rem;
		int reverse = 0;
		

		while (num != 0) 
		{
			rem = num % 10;
			reverse = reverse*10 + rem;
			num= num / 10;

		}
		Console.WriteLine("Reversed number is: " + reverse);
	}
}
