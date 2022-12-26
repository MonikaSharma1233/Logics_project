using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class D9_Faboncci
    {
        public static void FaboncciNo()
        {
            //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144
            int a = 0;
            int b = 1;
            Console.WriteLine("Enter the nth term till you want print series:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The series is: ");
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i < n-2; i++)
            {
                int c = (a + b);
                Console.WriteLine(c);
                a = b;
                b = c;

            }
        }
    }


