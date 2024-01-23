using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    class PlayerInventory
    {
        public List<IInventoryItem> Items { get; }

        public PlayerInventory()
        {
            Items = new List<IInventoryItem>();
        }

        public void DisplayInventory()
        {
            Console.WriteLine("\nPlayer's Inventory:");
            foreach (var item in Items)
            {
                item.DisplayInfo();
            }
        }
    }
}
