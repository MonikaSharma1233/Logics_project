using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics_Project
{
    public class D9_Stop_Watch
    {
        public static void Calculate_time()
        {
            Console.WriteLine("Enter the  time in seconds.\n");
            int mint = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the End time.\n");
            //Console.WriteLine("Enter the end hours.");
            //int end_hrs = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the end minitus.");
            //int end_mint = Convert.ToInt32(Console.ReadLine());

            // Create new stopwatch.
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing.
            stopwatch.Start();

            // Do something.
            for (int i = 0; i < mint; i++)
            {
                Thread.Sleep(1);
                Console.WriteLine(i);
            }

            // Stop timing.
            stopwatch.Stop();

            // Write result.
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
