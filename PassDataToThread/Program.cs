using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PassDataToThread
{
    // PASS DATA TO THREAD
    // We can pass data to a Thread by using
    // ParameterizedThreadStart Object
    // In the below code, we are calling
    // start() method of thread and are passing
    // a parameter to it. The only requirement
    // is that the value to be passed must be
    // only an object.
    // Alternatively we can use lambda expressions
    // to pass the desired data type to the thread
    // example is demonstrated below with DoWork2 method

    class Program
    {
        private const int REPETITIONS = 100;

        public static void DoWork(object obj)
        {
            char c = (char)obj;
            for (int i = 0; i < REPETITIONS; i++)
            {
                Console.Write(c);
            }
        }

        public static void DoWork2(char c)
        {
            for (int i = 0; i < REPETITIONS; i++)
            {
                Console.Write(c);
            }
        }

        static void Main(string[] args)
        {
            #region Start new thread with ParameterizedThreadStart Object
            Thread t = new Thread(DoWork);
            t.Start('A');
            #endregion

            #region Start new thread using lambda expression
            Thread t2 = new Thread(() => { DoWork2('C'); });
            t2.Start();
            #endregion

            // Call DoWork from main
            DoWork('B');

            Console.ReadKey();
        }
    }
}
