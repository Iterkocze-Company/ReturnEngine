using System;

namespace ReturnEngine
{
    public class Log
    {
        public static void Info(string wiad)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(wiad);
            Console.ForegroundColor = oldColor;
        }
        public static void Warn(string wiad)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(wiad);
            Console.ForegroundColor = oldColor;
        }
        public static void Suc(string wiad)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(wiad);
            Console.ForegroundColor = oldColor;
        }
        public static void Fail(string wiad)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(wiad);
            Console.ForegroundColor = oldColor;
        }
    }
}
