using System;

public class Q5_Prime_Factor
{
    public static void primefactor()
    {
        Console.WriteLine("Enter the number to check prime factors of number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int checkcount = 0;
        for (int i = 1; i <= num + 1; i++)
        {
            int expr = num % i;
            if (expr == 0)
            {
                checkcount++;
                Console.Write(i + " ");
            }
        }
        Console.WriteLine("\n");
        if (checkcount == 2)
        {
            Console.WriteLine("Number is Prime.");
        }
        else
        {
            Console.WriteLine("Number is not prime.");
        }
    }
}
