using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    internal class Item
    {
        public string Name { get; set; }    
        public string Description { get; set; }
        public double Weight { get; set; }
        public Item(string name, string description, double weight)
        {
            Name = name;
            Description = description;
            Weight = weight;
        }
    }
}
