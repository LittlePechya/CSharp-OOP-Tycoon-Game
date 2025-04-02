using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_Tycoon_Game
{
    abstract class Tool
    {
        public string Name { get; }
        public int Power { get; }
        public int Price { get; }

        protected Tool(string name, int power, int price)
        {
            Name = name;
            Power = power;
            Price = price;
        }
    }
}
