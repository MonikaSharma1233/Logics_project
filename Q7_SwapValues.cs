using System;

public class Q7_SwapValues
{
	public static void Swap_Numbers()
	{
        //int a = 5;
        //int b = 10;

        Console.WriteLine("Lets Swap the values of a and b.");
		Console.WriteLine("Give the value for a=");
		int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Give the value for b=");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Before swaping:");
        Console.WriteLine("Value of a is :  " + a + "   Value of b is :  " + b);
        a = a * b;
		b = a / b;
		a = a / b;
		Console.WriteLine("After swaping:");
		Console.WriteLine("Value of a is : "+a+"  Value of b is :  "+b);
        Console.WriteLine("\n");

        Console.WriteLine("Swapping with + and - operator.");
        int a1 = 25;
        int b1 = 29;
        Console.WriteLine("Before swaping:");
        Console.WriteLine("Value of a is =  " + a1 + "   Value of b is =  " + b1);
		a1 = a1 + b1; //25+29=54
		b1 = a1 - b1; //54-29=25
		a1 = a1 - b1;//54-25=29
        Console.WriteLine("After swaping:");
        Console.WriteLine("Value of a is = " + a1 + "  Value of b is =  " + b1);
        Console.WriteLine("\n");

    }
}
