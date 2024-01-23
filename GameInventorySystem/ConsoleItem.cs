using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    internal class ConsoleItem : Item, IInventoryItem
    {
        public string Platform { get; set; }
        public ConsoleItem(string name, string description, double weight, string platform) : base(name, description, weight)
        {
            Platform = platform;
        }
        public void Use()
        {
            Console.WriteLine($"Playing games on {Platform}. Enjoy your gaming session!");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Description: {Description}, Weight: {Weight}, Platform: {Platform}");
        }
    }
    }

