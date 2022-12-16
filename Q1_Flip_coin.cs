using System;

public class Q1_Flip_coin
{
    public static void flipcoin()
    {
        Console.WriteLine("Enter the number of times you want to flip the coin: ");
        int flip = Convert.ToInt32(Console.ReadLine());
        int headcount = 0;
        int tailcount = 0;
        for (int i = 1; i <= flip; i++)
        {
            Random ran = new Random();
            int num = ran.Next(2);

            //Console.WriteLine(num);
            if (num == 0)
            {
                tailcount++;
            }
            else
            {
                headcount++;
            }
        }
        Console.WriteLine(tailcount + " number of time generated Tail");
        Console.WriteLine(headcount + " number of time generated Head");
        int headper = (headcount * 100) / flip;
        int tailper = (tailcount * 100) / flip;
        Console.WriteLine(tailper + "%  generated Tail");
        Console.WriteLine(headper + "%  generated Head");

    }
}
