using System;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMessage();
            string msg = GetMessage();
            Console.ReadKey();
        }

        static void PrintMessage()
        {
            Console.WriteLine("Batman is the best! Spider-who?");
        }

        static string GetMessage()
        {
            Console.Write("Please enter your favorite superhero? ");
            string message = Console.ReadLine();
            return message;
        }

    }
}
