
using System;


public class Q10_GreatestNum
{
	public static void Check_greatestno()
	{
        Console.WriteLine("Lets check the largest number among three.");
		Console.WriteLine("Enter the Number 1:");
        int n1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Number 2:");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Number 3:");
        int n3 = Convert.ToInt32(Console.ReadLine());

        if(n1>n2)
        {
            if(n1>n3)
            {
                Console.WriteLine("Number 1 is Greatest.");
            }
            else
            {
                Console.WriteLine("Number 3 is Greatest.");
            }
        }
        else if(n2>n3)
        {
            Console.WriteLine("Number 2 is Greatest.");
        }
        else
        {
            Console.WriteLine("Number 3 is Greatest.");
        }
    }
}
