using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_Tycoon_Game
{
    static class InputManager
    {
        public static void HandleInvalidInput()
        {
            Console.WriteLine("Invalid input! Press any key to continue...");
            Console.ReadKey();
        }

        public static void WaitInput()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
