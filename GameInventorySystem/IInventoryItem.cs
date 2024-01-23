using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    internal interface IInventoryItem
    {
        void Use();
        void DisplayInfo();
    }
}
