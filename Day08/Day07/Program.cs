using Day07CL;
using Day07CL.Enums;
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

            FantasyWeapon sting = new FantasyWeapon(WeaponRarity.Legendary, 100, 1000, 100000);
            int damage = sting.DoDamage();
            Console.WriteLine($"We swing sting and do {damage} points of damage to the rat.");
        }
    }
}
