using System;
using Sys = Cosmos.System;
using Cosmos.HAL;

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
            WaitSeconds(4);
            Console.WriteLine("\n\n                                Booting....                                   ");
            WaitSeconds(2);
            Console.Clear();
            WaitSeconds(1);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("GoPixelOS 1.0.1                                                                 ");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        protected override void Run()
        {
            Console.Write("$ ");
            string input = Console.ReadLine();



            switch (input) {
                case "cls":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("GoPixelOS 1.0.1                                                                 ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "help":
                    Console.WriteLine();
                    Console.WriteLine("help - shows this list");
                    Console.WriteLine("cls - clear the 'terminal' ");
                    Console.WriteLine("reboot - reboot the system");
                    Console.WriteLine("shutdown - shutdown the system");
                    Console.WriteLine("systeminfo - show things about the system");
                    Console.WriteLine();
                    break;
                case "shutdown":
                    Sys.Power.Shutdown();
                    break;
                case "reboot":
                    Sys.Power.Reboot();
                    break;
                case "systeminfo":
                    Console.WriteLine();
                    Console.WriteLine("Operating System: GoPixelOS 1.0.1");
                    Console.WriteLine("Kernel Compiler: Cosmos");
                    Console.WriteLine("Author: IsaacPar");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("command not found, use 'help' to see a list of avaliable commands");
                    break;
            }
        }
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
    public class Commands
    {
        public void cls()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("GoPixelOS 1.0.1                                                                 ");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void help()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("help - show this command list");
            Console.WriteLine("cls - clear the 'terminal' ");
            Console.WriteLine("shutdown - shutdown the pc or virtual machine");
            Console.WriteLine("reboot - reboot the pc or virtual machine");
            Console.WriteLine("systeminfo - show things about the system");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        public void shutdown()
        {
            Cosmos.System.Power.Shutdown();
        }
        public void reboot()
        {
            Cosmos.System.Power.Reboot();
        }
        public void systeminfo()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Operating System: GoPixelOS 1.0.1");
            Console.WriteLine("Kernel Compiler: Cosmos");
            Console.WriteLine("Author: IsaacPar");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
