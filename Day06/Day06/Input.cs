using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal static class Input
    {
        public static int ReadInteger(string prompt, int min, int max)
        {
            do
            {
                Console.WriteLine(prompt);
                if (int.TryParse(Console.ReadLine(), out int value) && value >= min && value <= max)
                    return value;
                Console.WriteLine("That is not a valid entry. Please try again.");
            } while (true);
        }

        public static void ReadChoice(string prompt, string[] options, out int selection)
        {
            foreach (var item in options)
                Console.WriteLine(item);

            selection = ReadInteger(prompt, 1, options.Length);
        }
    }
}
