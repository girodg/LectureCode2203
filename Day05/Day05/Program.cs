using System;
using System.Diagnostics;
using System.Threading;

namespace Day05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            Console.CursorVisible = false;
            //Method(5);
            int bound = Math.Min(Console.WindowHeight, Console.WindowWidth);
            int x1 = 0, y1 = 0;

            Boxes(x1, y1, bound - 1, bound / 2);

            Console.ResetColor();
            Console.ReadKey();
            Console.CursorVisible = true;
        }

        static Random randy = new Random();
        private static void Boxes(int x1, int y1, int bound,int stop)
        {
            //our exit condition (we stop looping when...
            if (x1 > stop) return;

            GetColor();
            //Debug.WriteLine($"{x1},{y1} {bound} {stop}");
            DrawBox(x1, y1, bound);

            Boxes(x1 + 1, y1 + 1, bound - 2, stop);//recursively call Boxes

            //only get here when the exit condition has happened
            Console.BackgroundColor = ConsoleColor.Black;
            DrawBox(x1, y1, bound);
        }

        private static void GetColor()
        {
            do
                Console.BackgroundColor = (ConsoleColor)randy.Next(16);
            while (Console.BackgroundColor == ConsoleColor.Black);
        }

        private static void DrawBox(int x1, int y1, int bound)
        {
            Horizontal(x1, y1, x1 + bound);
            Horizontal(x1, y1 + bound, x1 + bound);
            Vertical(x1, y1, y1 + bound);
            Vertical(x1 + bound, y1, y1 + bound);
            Thread.Sleep(50);
        }

        private static void Vertical(int x1, int y1, int y2)
        {
            for (int i = y1; i < y2; i++)
            {
                Console.SetCursorPosition(x1, i);
                Console.Write(' ');
            }
        }

        private static void Horizontal(int x1, int y1, int x2)
        {
            Console.SetCursorPosition(x1, y1);
            for (int i = x1; i <= x2; i++)
            {
                Console.Write(' ');
            }
        }

        static void Method(int num)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
