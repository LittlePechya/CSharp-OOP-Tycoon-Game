using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_Tycoon_Game
{
    class Game
    {
        private Player player;

        public void Start()
        {
            Console.Write("Enter player name: ");
            string name = Console.ReadLine();
            player = new Player(name);
            Console.WriteLine("Welcome to the game, " + player.Name);
            InputManager.WaitInput();
            RunMenu();
        }
        
        public void RunMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Your money: " + player.Money);
                Console.WriteLine("1. Get resources");
                Console.WriteLine("2. Sell all resources");
                Console.WriteLine("3. Buy a tool");
                Console.WriteLine("4. Equip a tool");
                Console.WriteLine("5. Exit the game");

                string choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        GetRecourcesMenu();
                        break;
                    case "2":
                        player.SellAllResources();
                        InputManager.WaitInput();
                        break;
                    case "3":
                        BuyToolMenu();
                        break;
                    case "4":
                        EquipToolMenu();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                        case "6":
                        break;
                }
            }
        }

        private void GetRecourcesMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Get wood");
            Console.WriteLine("2. Get stone");
            Console.WriteLine("3. Get copper");
            Console.WriteLine("4. Get iron");
            Console.WriteLine("5. Get diamond");
            Console.WriteLine("6. Back to the main menu");
            
            string choice = Console.ReadLine();

            Resource resource = null;

            switch (choice)
            {
                case "1":
                    resource = new Resources.Wood();
                    break;
                case "2":
                    resource = new Resources.Stone();
                    break;
                case "3":
                    resource = new Resources.Copper();
                    break;
                case "4":
                    resource = new Resources.Iron();
                    break;
                case "5":
                    resource = new Resources.Diamond();
                    break;
                case "6":
                    RunMenu();
                    break;
                default:
                    InputManager.HandleInvalidInput();
                    RunMenu();
                    break;

            }
            player.Mine(resource);
            InputManager.WaitInput();
        }

        private void BuyToolMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Buy a stick");
            Console.WriteLine("2. Buy a sledgehammer");
            Console.WriteLine("3. Buy a pickaxe");
            Console.WriteLine("4. Buy a drill");
            Console.WriteLine("5. Buy a bore");
            Console.WriteLine("6. Back to the main menu");

            string choice = Console.ReadLine();

            Tool tool = null;

            switch (choice)
            {
                case "1":
                    tool = new Tools.Stick();
                    break;
                case "2":
                    tool = new Tools.Sledgehammer();
                    break;
                case "3":
                    tool = new Tools.Pickaxe();
                    break;
                case "4":
                    tool = new Tools.Drill();
                    break;
                case "5":
                    tool = new Tools.Bore();
                    break;
                case "6":
                    RunMenu();
                    break;
                default:
                    InputManager.HandleInvalidInput();
                    RunMenu();
                    break;
            }

            player.BuyTool(tool);
            InputManager.WaitInput();
        }

        private void EquipToolMenu()
        {
            Console.Clear();
            Console.WriteLine("Avaliable tools:");
            int showedItems = 0;

            for (int i = 0; i < player.OwnedTools.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + player.OwnedTools[i].Name);
                showedItems++;
            }

            Console.WriteLine($"{showedItems + 1}. Back to the main menu");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice > 0 && choice <= showedItems)
            {
                player.EquipTool(player.OwnedTools[choice - 1]);
                InputManager.WaitInput();
            } else if (choice == showedItems + 1)
            {
                RunMenu();
            }
            else
            {
                InputManager.HandleInvalidInput();
                RunMenu();
            }
        }
    }
}
