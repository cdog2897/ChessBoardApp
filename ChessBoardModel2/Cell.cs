using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel2
{
    public class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool CurrentlyOccupied { get; set; }
        public bool LegalNextMove { get; set; }

        public Cell(int row, int col)
        {
            Row = row;
            Column = col;
        }

    }
}
