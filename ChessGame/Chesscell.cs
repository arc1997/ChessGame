using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Chesscell
    {
        private int x;
        private int y;
        private ChessPiece? chessPiece;

        public Chesscell(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.chessPiece = null;
        }
    }
}
