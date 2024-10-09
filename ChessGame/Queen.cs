using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Queen : ChessPiece
    {
        private Color color;
        private PieceName pieceName;
        private bool isdead;
        public PieceName getName()
        {
            return pieceName;
        }

        public bool isDead()
        {
            return isdead;
        }

        public void Move(Chesscell source, Chesscell destination, ChessBoard chessBoard)
        {
            throw new NotImplementedException();
        }

        public void setDead(bool dead)
        {
            this.isdead = dead;
        }
    }
}
