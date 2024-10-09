using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public interface Board
    {
        void applyMove(Move move);

        void Display();
    }
}
