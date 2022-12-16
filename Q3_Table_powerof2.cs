using System;

public class Q3_Table_powerof2
{
    public static void tableofpoweroftwo()
    {
        Console.WriteLine("Enter the value for n to show the table nth term: ");
        int n = Convert.ToInt32(Console.ReadLine());


        if (n >= 0 && n < 31)
        {
            for (int j = 0; j < n + 1; j++)
            {
                double expr = Math.Pow(2, j);

                Console.WriteLine("2^" + j + "= " + expr);
            }
        }
        else
        {
            Console.WriteLine("Invalid Input!!!");
        }
    }
}
