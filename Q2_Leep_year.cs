using System;

public class Q2_Leep_year
{
    public static void leapyear()
    {
        int check = 0;
        int check1 = 0;
        Console.WriteLine("Enter the year to know, Is it leap year or not: ");
        int year = Convert.ToInt32(Console.ReadLine());
        if (year > 1000 && year < 9999)
        {
            check = year % 400;
            check1 = year % 4;
            if (check == 0 && check1 == 0)
            {
                Console.WriteLine("Entered year is a leep year.");
            }
            else
            {
                Console.WriteLine("Entered year is not a leap year.");
            }
        }
        else
        {
            Console.WriteLine("Invalid Input.");
        }
    }
}
