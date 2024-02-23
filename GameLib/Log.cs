using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib
{
    public class Log
    {
        public static void Info(String msg)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[Info] " + msg);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Debug(String msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Debug] " + msg);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Error(String msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[Error] " + msg);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Warning(String msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("[Warning] " + msg);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void NewLine(int Amount)
        {
            for (int i = 0; i < Amount; i++)
            {
                Console.Write("\n");
            }
        }
        public static void NewLine()
        {
            Console.Write("\n");
        }
        public static void Line(int Width)
        {
            for (int i = 0; i < Width; i++)
            {
                Console.Write("-");
            }
            Console.Write("\n");
        }
    }
}
