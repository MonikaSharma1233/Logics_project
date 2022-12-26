using System;
using System.Globalization;

public class D9_Coupan_no
{
    
    public static int generate_random()
    {
        Random r1 = new Random();
        int randomno = r1.Next();
        // Console.WriteLine(randomno);
        return randomno;
    }

    public static void generate_coupan()
    {

        Console.WriteLine("How many Coupans you want to print: ");
        int n =Convert.ToInt32( Console.ReadLine());
       
        int random1 = 0;
        int check = random1;
        Console.WriteLine(n + " Coupans numbers are: ");

        for (int i = 0; i < n; i++)
        {
            random1 = generate_random();
            if(random1 == check)
            {
                random1 = generate_random();
                check=random1;
            }
            Console.WriteLine(random1);
            

            //Console.WriteLine("All Coupan numbers are Distinct.");
        }
    }

}




    


  
