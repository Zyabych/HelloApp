using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            Console.Beep(523, 500);
            Console.Beep(587, 500);
            Console.Beep(659, 500);
            Console.Beep(698, 500);
            Console.Beep(784, 500);
            Console.Beep(880, 500);
            Console.Beep(988, 500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            float t = 25;
            Console.WriteLine(t);
            Console.WriteLine("Hello World!");
            Console.ReadKey();


        }
    }
}
