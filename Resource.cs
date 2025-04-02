using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_Tycoon_Game
{
    abstract class Resource
    {
        public string Name { get; }
        public int RequiredPower { get; }
        public int SellPrice { get; }

        protected Resource(string name, int requiredPower, int sellPrice)
        {
            Name = name;
            RequiredPower = requiredPower;
            SellPrice = sellPrice;
        }
    }
}
