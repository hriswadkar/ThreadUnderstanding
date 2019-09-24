using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadRaceConditions
{
    // RACE CONDITION
    // Race condition is a situation where two threads are
    // fighting for same variable and as a result the code
    // starts behaving in a unpredictable manner.
    // In the below code, if we define i variable inside
    // for loop, the program will work correctly and display
    // total 10 * because the variable will be created
    // separately for each thread
    // Race condition can be fixed by "locking"
    // Keep the data that you share between two threads to
    // absolute minimum
    class Program
    {
        public static int i = 0;

        public static void DoWork()
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("*");
            //}
            for (i = 0; i < 5; i++)
            {
                Console.Write("*");
            }
        }

        static void Main(string[] args)
        {
            // Start thread to display 5 *
            Thread t = new Thread(DoWork);
            t.Start();

            // Display additional 5 *
            DoWork();

            Console.ReadKey();
        }
    }
}
