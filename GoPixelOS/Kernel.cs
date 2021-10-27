using System;
using Sys = Cosmos.System;
using Cosmos.HAL;
using Apps =  GoPixelOS.Applications;

namespace GoPixelOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("\n\n                                Loading....                                   ");
            Helpers.WaitSeconds(2);
            Console.WriteLine("\n\n                                Booting....                                   ");
            Helpers.WaitSeconds(2);
            Console.Clear();
            Helpers.WaitSeconds(1);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("GoPixelOS 1.0.1                                                                 ");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        protected override void Run()
        {
            Console.Write("$ ");
            string input = Console.ReadLine().ToLower();

            
            }
        }
        class Helpers
        {
            public static void WaitSeconds(int secNum)
            {
                int StartSec = RTC.Second;
                int EndSec;
                if (StartSec + secNum > 59)
                {
                    EndSec = 0;
                }
                else
                {
                    EndSec = StartSec + secNum;
                }
                while (RTC.Second != EndSec)
                {
                    // Loop round
                }
            }
        }
        
    
}
