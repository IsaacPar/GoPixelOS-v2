using System;
using Sys = Cosmos.System;
using Cosmos.HAL;
using Commands = GoPixelOS.Command;
using Cosmos.System.ExtendedASCII;
using System.Text;

namespace GoPixelOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            
            Helpers.Boot();
            Console.BackgroundColor = ConsoleColor.Blue;                                                              
            Console.ForegroundColor = ConsoleColor.White;                                                          
            Console.WriteLine("GoPixelOS 1.0.2                                                                ");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        protected override void Run()
        {
            Console.Write("$ ");
            string input = Console.ReadLine().ToLower();

            
            Commands.ParseSimple(input);
            
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
            public static bool Boot()
            {
            Encoding.RegisterProvider(CosmosEncodingProvider.Instance);

            Console.InputEncoding = Encoding.GetEncoding(437);
            Console.OutputEncoding = Encoding.GetEncoding(437);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Write("\n\n                                Loading....                                   ");
            Console.WriteLine("                       █");
            Helpers.WaitSeconds(1);
            Console.Write("                           █████████");
            Helpers.WaitSeconds(1);
            Console.Write("                           ████████████████");
            Console.Clear();
            return true;
            } 
        }
        
    
}
