using ChessBoardModel2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel2
{
    public class Board
    {
        public int Size { get; set; }
        public Cell[,] Grid { get; set; }

        public Board(int s)
        {
            Size = s;
            Grid = new Cell[Size, Size];

            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    Grid[x, y] = new Cell(x, y);
                }
            }
        }

        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {
            // step 1: clear all previous markings
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    Grid[x, y].LegalNextMove = false;
                    Grid[x, y].CurrentlyOccupied = false;
                }
            }

            // step 2: find all legal moves and mark cells as "legal"
            switch (chessPiece)
            {
                case "Knight":
                    isSafe(currentCell.Row + 2, currentCell.Column + 1);

                    isSafe(currentCell.Row + 2, currentCell.Column - 1);

                    isSafe(currentCell.Row - 2, currentCell.Column + 1);

                    isSafe(currentCell.Row - 2, currentCell.Column - 1);

                    isSafe(currentCell.Row + 1, currentCell.Column + 2);

                    isSafe(currentCell.Row + 1, currentCell.Column - 2);

                    isSafe(currentCell.Row - 1, currentCell.Column + 2);

                    isSafe(currentCell.Row - 1, currentCell.Column - 2);
                   
                    break;

                case "King":
                    isSafe(currentCell.Row + 1, currentCell.Column - 1);

                    isSafe(currentCell.Row + 1, currentCell.Column);

                    isSafe(currentCell.Row + 1, currentCell.Column + 1);

                    isSafe(currentCell.Row, currentCell.Column - 1);

                    isSafe(currentCell.Row, currentCell.Column + 1);

                    isSafe(currentCell.Row - 1, currentCell.Column - 1);

                    isSafe(currentCell.Row - 1, currentCell.Column);

                    isSafe(currentCell.Row - 1, currentCell.Column + 1);
                    
                    break;

                case "Rook":
                    
                    for (int row = 1; row < Grid.GetLength(0); row++)
                    {
                        isSafe(currentCell.Row + row, currentCell.Column);
                    }
                    for(int col = 1; col < Grid.GetLength(1); col++)
                    {
                        isSafe(currentCell.Row, currentCell.Column + col);
                    }
                    for(int row = -1; row > -(Grid.GetLength(0)); row--)
                    {
                        isSafe(currentCell.Row + row, currentCell.Column);

                    }
                    for(int col = -1; col > -(Grid.GetLength(1)); col--)
                    {
                        isSafe(currentCell.Row, currentCell.Column + col);
                    }
                    break;

                case "Bishop":
                    int rows = 1;
                    int cols = 1;
                    
                    // down, right
                    for(int i = 0; i < Grid.GetLength(0); i++)
                    {
                        isSafe(currentCell.Row + rows, currentCell.Column + cols);
                        rows++;
                        cols++;
                    }
                    // down, left
                    rows = 1;
                    cols = -1;
                    for (int i = 0; i < Grid.GetLength(0); i++)
                    {
                        isSafe(currentCell.Row + rows, currentCell.Column + cols);
                        rows++;
                        cols--;
                    }
                    //up, left
                    rows = -1;
                    cols = -1;
                    for (int i = 0; i < Grid.GetLength(0); i++)
                    {
                        isSafe(currentCell.Row + rows, currentCell.Column + cols);
                        rows--;
                        cols--;
                    }
                    //up, right
                    rows = -1;
                    cols = 1;
                    for (int i = 0; i < Grid.GetLength(0); i++)
                    {
                        isSafe(currentCell.Row + rows, currentCell.Column + cols);
                        rows--;
                        cols++;
                    }
                    break;

                case "Queen":
                    for (int row = 1; row < Grid.GetLength(0); row++)
                    {
                        isSafe(currentCell.Row + row, currentCell.Column);
                    }
                    for (int col = 1; col < Grid.GetLength(1); col++)
                    {
                        isSafe(currentCell.Row, currentCell.Column + col);
                    }
                    for (int row = -1; row > -(Grid.GetLength(0)); row--)
                    {
                        isSafe(currentCell.Row + row, currentCell.Column);

                    }
                    for (int col = -1; col > -(Grid.GetLength(1)); col--)
                    {
                        isSafe(currentCell.Row, currentCell.Column + col);
                    }

                    rows = 1;
                    cols = 1;
                    // down, right
                    for (int i = 0; i < Grid.GetLength(0); i++)
                    {
                        isSafe(currentCell.Row + rows, currentCell.Column + cols);
                        rows++;
                        cols++;
                    }
                    // down, left
                    rows = 1;
                    cols = -1;
                    for (int i = 0; i < Grid.GetLength(0); i++)
                    {
                        isSafe(currentCell.Row + rows, currentCell.Column + cols);
                        rows++;
                        cols--;
                    }
                    //up, left
                    rows = -1;
                    cols = -1;
                    for (int i = 0; i < Grid.GetLength(0); i++)
                    {
                        isSafe(currentCell.Row + rows, currentCell.Column + cols);
                        rows--;
                        cols--;
                    }
                    //up, right
                    rows = -1;
                    cols = 1;
                    for (int i = 0; i < Grid.GetLength(0); i++)
                    {
                        isSafe(currentCell.Row + rows, currentCell.Column + cols);
                        rows--;
                        cols++;
                    }
                    break;
                default:
                    break;
            }
            Grid[currentCell.Row, currentCell.Column].CurrentlyOccupied = true;

        }

        public bool isSafe(int row, int col)
        {
            try
            {
                if (row < Grid.GetLength(0) && col < Grid.GetLength(1))
                {
                    Grid[row, col].LegalNextMove = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            
        }
    }
}
