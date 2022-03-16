using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Inventory
    {
        private int _capacity;
        private List<FantasyWeapon> _items;

        public int Capacity
        {
            get { return _capacity; }
            set { 
                if(value > 0)
                    _capacity = value; 
            }
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public List<FantasyWeapon> Items
        {
            get { return _items; }
            private set { _items = value; }
        }

        public Inventory(int capacity, List<FantasyWeapon> items)
        {
            Capacity = capacity;
            Items = items.ToList();
        }

        public void AddItem(FantasyWeapon itemToAdd)
        {
            if (Count == Capacity)
                throw new Exception("Dora's hands are full, fool!");

            _items.Add(itemToAdd);
        }

        public void PrintInventory()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                _items[i].Display();
                //FantasyWeapon fw = _items[i];
                //Console.WriteLine($"A level {fw.Level} {fw.Rarity} weapon that can do {fw.MaxDamage} and cost {fw.Cost}.");
                //if (fw is BowWeapon bow)
                //    Console.WriteLine($"\tIt also has {bow.ArrowCount} arrows and can hold {bow.ArrowCapacity} arrows.");
                
            }
        }
    }
}
