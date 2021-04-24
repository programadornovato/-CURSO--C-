using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("Hola mundo :)");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hola Novato :)");
            Console.Read();
        }
    }
}
