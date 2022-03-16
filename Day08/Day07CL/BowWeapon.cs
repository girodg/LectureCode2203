﻿using Day07CL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class BowWeapon : FantasyWeapon
    {
        public int ArrowCapacity { get; set; }
        public int ArrowCount { get; set; }

        public BowWeapon(int arrowCap, int arrowCount, WeaponRarity rarity, int level, int maxDamage, int cost) :
            base(rarity, level, maxDamage, cost)
        {
            ArrowCapacity = arrowCap;
            ArrowCount = arrowCount;
        }
    }
}
