using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    internal class Weapon : Item, IInventoryItem
    {
        public int Damage { get; set; }

        public Weapon(string name, string description, double weight, int damage) : base(name, description, weight)
        {
            Damage = damage;
        }

        public void Use()
        {
            Console.WriteLine($"Equipping {Name}. Damage: {Damage}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Description: {Description}, Weight: {Weight}");
        }
    }
}
