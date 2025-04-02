using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_Tycoon_Game
{
    class Resources
    {
        public class Wood : Resource { public Wood() : base("Wood", 1, 5) { } }
        public class Stone : Resource { public Stone() : base("Stone", 2, 10) { } }
        public class Copper : Resource { public Copper() : base("Copper", 3, 20) { } }
        public class Iron : Resource { public Iron() : base("Iron", 4, 40) { } }
        public class Diamond : Resource { public Diamond() : base("Diamond", 5, 100) { } }
    }
}
