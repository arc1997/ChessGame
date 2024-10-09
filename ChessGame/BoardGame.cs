using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public abstract class BoardGame
    {
        private Board board;
        private Queue<Player> playerQueue;

        public BoardGame(Board board, Queue<Player> playerQueue)
        {
            this.board = board;
            this.playerQueue = playerQueue;
        }

        public void StartGame()
        {
            while (true)
            {
                Player player = playerQueue.Dequeue();
                Move move = player.MakeMove();
                board.applyMove(move);
                if (isOver())
                {
                    Console.WriteLine("Game Over....." +  player.Name + " won");
                    break;
                }
                playerQueue.Enqueue(player);
            }
        }

        public abstract bool isOver();
    }
}
