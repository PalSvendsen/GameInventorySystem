using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    class Consumable : Item, IInventoryItem
    {
        public int HealthBonus { get; set; }
        public int ManaBonus { get; set; }

        public Consumable(string name, string description, double weight, int healthbonus, int manabonus):base(name, description, weight)
        {
            HealthBonus = healthbonus;
            ManaBonus = manabonus;
        }
        public void Use()
        {
            Console.WriteLine($"Using {Name}. Health Bonus: {HealthBonus}, Mana Bonus: {ManaBonus}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Description: {Description}, Weight: {Weight}");
        }
    }
}
