using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpDay6Assignments
{
    internal class StopWatch
    {
        public void TimeElapsed()
        {
            Stopwatch stopwatch = new Stopwatch();  //Creating object of StopWatch Class
            stopwatch.Start(); //Start the stopwatch
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("Hello");
            //}
            Thread.Sleep(10000);//Running process rest for while
            stopwatch.Stop();// Stop the Stopwatch
            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds / 10);
            Console.WriteLine("\nRunTime " + elapsedTime);
            Console.WriteLine("\nTime elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
