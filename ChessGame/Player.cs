using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public abstract class Player
    {
        public abstract string Name { get; set; }

        public Player(String name) 
        {
            Name = name;
        }
        public abstract Move MakeMove();
    }
}
