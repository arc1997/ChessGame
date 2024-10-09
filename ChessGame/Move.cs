using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Move
    {
        public Pair source;
        public Pair destination;

        public Move(Pair source, Pair destination) 
        {
            this.source = source;
            this.destination = destination;
        }

        public Pair getSource()
        {
            return source;
        }
        public Pair getDestination()
        {
            return destination;
        }
    }

    public class Pair
    {
        public int x;
        public int y;
        public Pair(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int getX() { return x; } 
        public int getY() { return y; }
    }
}
