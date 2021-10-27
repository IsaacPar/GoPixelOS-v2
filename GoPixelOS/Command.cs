using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Apps = GoPixelOS.Applications;

namespace GoPixelOS
{
    class Command
    {
        public static void ParseSimple(string command)
        {
            switch (command)
            {
                case "cls":
                    Console.Clear();
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
                case "apps":
                    Apps.init();
                    break;
                default:

                    Console.WriteLine("command not found, use 'help' to see a list of avaliable commands");
                    break;
            }

        }
    }
}
