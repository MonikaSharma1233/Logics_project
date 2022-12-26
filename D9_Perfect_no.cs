using System;

public class D9_Perfect_no
{
	public static void Check_perfect_no()
	{
		int n, i, sum, min, max;
        Console.WriteLine("Give the values for check the  perfect numbers.");
        Console.WriteLine("Enter the min Value : ");
		min=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the Max Value : ");
		max=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The perfect numbers in the range : ");

		for(n=min;n<=max;n++)
		{
			 i = 1;
			sum = 0;
			while (i < n)
			{
				if (n % i == 0)
				{
					sum = sum + i;
				}
				i++;
			}

			if (sum == n)
			{
				Console.Write("{0} ", n);
			}
			else
			{
				Console.WriteLine("No Number.");
			}
			

		}
		
	}
}
