using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_Tycoon_Game
{
    class Tools
    {
        public class Stick : Tool { public Stick() : base("Stick", 1, 0) { } }
        public class Sledgehammer : Tool { public Sledgehammer() : base("Sledgehammer", 2, 10) { } }
        public class Pickaxe : Tool { public Pickaxe() : base("Pickaxe", 3, 50) { } }
        public class Drill : Tool { public Drill() : base("Drill", 4, 100) { } }
        public class Bore : Tool { public Bore() : base("Bore", 5, 200) { } }
    }
}
