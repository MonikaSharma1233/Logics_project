using System;

public class Q6_Quotient_Reminder
{
	public static void Quotient_and_Reminder_check()
	{
		int divident = 50;
		int divisor = 10;
		int Quotient = divident / divisor;
		int Reminder= divident % divisor;


		Console.WriteLine("divident {0} divisor {1} ", divident, divisor);

        Console.WriteLine("Quotient = " + Quotient);
        Console.WriteLine("Reminder = "+Reminder);


    }
}
