using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace timer_class_test
{
    class Program
    {
        public static int secondsCount = 0;
        public static Timer aTmr = new Timer(1000);
        static void Main(string[] args)
        {
            aTmr.Elapsed += ATmr_Elapsed;
            aTmr.Enabled = true;
            aTmr.AutoReset = true;
            aTmr.Start();
            Console.ReadKey();
        }

        private static void ATmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            //secondsCount = secondsCount + 1;
            secondsCount++;
            Console.WriteLine(secondsCount + " Seconds");
           // throw new NotImplementedException();
        }
    }
}
