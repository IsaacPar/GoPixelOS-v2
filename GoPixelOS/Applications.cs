using System;
using System.Collections.Generic;
using System.Text;

namespace GoPixelOS
{
    public class Applications
    {
        public static void calc()
        {
            Console.WriteLine("Calculator                                                                      ");
        }
        public static void init()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Applications                                                                    ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("     1) Exit");
            Console.Write("\n\n Option: ");
            var app = Console.ReadLine();

            switch (app)
            {
                case "1":
                    break;
                default:
                    init();
                    break;
            }
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("GoPixelOS 1.0.1                                                                 ");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
