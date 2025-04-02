using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_Tycoon_Game
{
    class Player
    {
        public string Name { get; set; }
        public int Money { get; private set; }
        public Dictionary<Resource, int> Inventory { get; private set; }
        public List<Tool> OwnedTools { get; }
        public Tool EquippedTool { get; private set; }

        public Player(string name)
        {
            Name = name;
            Money = 0;
            Inventory = new Dictionary<Resource, int>();
            OwnedTools = new List<Tool>();
        }

        public void Mine(Resource resource)
        {
            if (EquippedTool == null)
            {
                Console.WriteLine("You need to equip a tool first!");
                return;
            }

            if (EquippedTool.Power >= resource.RequiredPower)
            {
                if (!Inventory.ContainsKey(resource))
                {
                    Inventory[resource] = 0;
                }
                Inventory[resource]++;
                Console.WriteLine("You gathered 1 " + resource.Name);
                return;
            } else
            {
                Console.WriteLine("Your tool is not powerful enough to mine this resource! You need " + resource.RequiredPower + " tool power");
            }
        }

        public void SellAllResources()
        {
            int totalMoney = 0;
            foreach (var item in Inventory)
            {
                int quntity = item.Value;
                int price = item.Key.SellPrice;
                totalMoney += quntity * price;
                Console.WriteLine("You sold " + quntity + " " + item.Key.Name + " for " + quntity * price);
            }
            Console.WriteLine(totalMoney + " was added to your balance");
            Money += totalMoney;
            Inventory.Clear();
        }

        public void BuyTool(Tool tool)
        {
            if (OwnedTools.Contains(tool))
            {
                Console.WriteLine("You already have this tool");
                return;

            }
            if (Money >= tool.Price)
            {
                Money -= tool.Price;
                OwnedTools.Add(tool);
                Console.WriteLine("You bought a " + tool.Name);
            } else
            {
                Console.WriteLine($"You don't have enough money to buy this tool. Price is {tool.Price}, but you only have {Money} money");

            }
        }

        public void EquipTool(Tool tool)
        {
            if (OwnedTools.Contains(tool))
            {
                EquippedTool = tool;
                Console.WriteLine("You equipped a " + tool.Name);
            } else
            {
                Console.WriteLine("You don't own this tool");
            }
        }
    }
}
