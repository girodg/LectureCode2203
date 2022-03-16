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
            List<FantasyWeapon> items = new List<FantasyWeapon>();
            items.Add(WeaponFactory.CreateWeapon(WeaponRarity.Common, 1, 10, 5));
            items.Add(WeaponFactory.CreateWeapon(WeaponRarity.Legendary, 100, 1000, 100000));
            items.Add(new BowWeapon(15,5,WeaponRarity.Rare, 50, 500, 50000));//upcasting
            items.Add(new BowWeapon(15, 5, WeaponRarity.Uncommon, 20, 200, 10000));//upcasting
            Inventory backpack = new Inventory(4, items);

            try
            {
                backpack.AddItem(new BowWeapon(15, 5, WeaponRarity.Uncommon, 20, 200, 10000));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Dora says: {ex.Message}");
            }

            FantasyWeapon sting = new FantasyWeapon(WeaponRarity.Legendary, 100, 1000, 100000);
            int damage = sting.DoDamage();
            Console.WriteLine($"We swing sting and do {damage} points of damage to the rat.");

            FantasyWeapon fw = WeaponFactory.CreateWeapon(WeaponRarity.Common, 1, 10, 5);
        }
    }
}
