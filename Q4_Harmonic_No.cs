using System;

public class Q4_Harmonic_No
{
    public static void Harmonicno()
    {
        Console.WriteLine("Enter valu for n to print Harmonic no till nth term: ");
        int num = Convert.ToInt32(Console.ReadLine());
        string s = " + ";
        for (int i = 1; i < num + 1; i++)
        {
            if (i == num)
            {
                s = ".";
            }
            Console.Write("1/" + i + s);

        }
    }
}
