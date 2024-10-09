using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public enum PieceName
    {
        KING,
        QUEEN,
        PAWN1,
        PAWN2,
        PAWN3,
        PAWN4,
        PAWN5,
        PAWN6,
        PAWN7,
        PAWN8,
        ROOK1,
        ROOK2,
        KNIGHT1,
        KNIGHT2,
        BISHOP1,
        BISHOP2
    }
    public enum Color
    {
        BLACK,
        WHITE
    }
    public interface ChessPiece
    {
        void Move(Chesscell source, Chesscell destination, ChessBoard chessBoard);

        bool isDead();

        void setDead(bool dead);

        PieceName getName();

    }
}
