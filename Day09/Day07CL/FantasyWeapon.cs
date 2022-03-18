using Day07CL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class FantasyWeapon
    {
        public WeaponRarity Rarity { get; private set; }
        public int Level { get; private set; }
        public int MaxDamage { get; private set; }
        public int Cost { get; private set; }

        //public int DoDamage()
        //{
        //    Random random = new Random();
        //    //explicit cast
        //    int damage = (int)(random.NextDouble() * MaxDamage);
        //    return damage;
        //}
        public int DoDamage(int enchantment = 0)//make enchantment optional
        {
            Random random = new Random();
            //explicit cast
            int damage = (int)(random.NextDouble() * (MaxDamage + enchantment));
            return damage;
        }
        public FantasyWeapon(WeaponRarity rarity, int level, int maxDamage, int cost)
        {
            Rarity = rarity;
            Level = level;
            MaxDamage = maxDamage;
            Cost = cost;
        }

        public virtual void Display()
        {
            Console.WriteLine($"A level {Level} {Rarity} weapon that can do {MaxDamage} and cost {Cost}.");
        }
    }
}
