using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Extensions
    {
        public static List<BowWeapon> Bows(this Inventory inventory)
        {
            var list = new List<BowWeapon>();
            foreach (var item in inventory.Items)
            {
                if(item is BowWeapon)
                    list.Add((BowWeapon)item);
            }
            return list;
        }
    }
}
