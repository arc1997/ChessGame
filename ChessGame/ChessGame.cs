using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class ChessGame : BoardGame
    {
        public ChessGame(Board board, Queue<Player> playerQueue) : base(board, playerQueue)
        {

        }

        public override bool isOver()
        {
            return false;
        }
    }
}
