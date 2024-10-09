using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class ChessBoard : Board
    {
        private List<List<Chesscell>> cells;
        private static int rows = 8;
        private static int cols = 8;
        public ChessBoard() 
        {
            this.cells = new List<List<Chesscell>>();

            for(int i = 0;i < rows; i++)
            {
                List<Chesscell> cell = new List<Chesscell>();
                for(int j = 0;j < cols; j++)
                {
                    cell.Add(new Chesscell(i,j));
                }
                this.cells.Add(cell);
            }           
        }

        public void applyMove(Move move)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}
