using Day07CL;
using System;
using System.Collections.Generic;

namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>()
            {
                "Map", "Shovel", "Pickaxe", "Helmet"
            };
            Inventory backpack = new Inventory(4, items);

            try
            {
                backpack.AddItem("Sword of black flame");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Dora says: {ex.Message}");
            }
        }
    }
}
