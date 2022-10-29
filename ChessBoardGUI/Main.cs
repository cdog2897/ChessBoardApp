using ChessBoardModel2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessBoardGUI
{
    public partial class Main : Form
    {
        // reference to the class board
        static Board myBoard = new Board(8);
        // grid of buttons
        public Button[,] btnGrid = new Button[myBoard.Size, myBoard.Size];


        public Main()
        {
            InitializeComponent();
            populateBoard();
        }

        public void populateBoard()
        {

            int buttonSize = mainPanel.Width / myBoard.Size;

            mainPanel.Height = mainPanel.Width;

            for (int x = 0; x < myBoard.Size; x++)
            {
                for(int y = 0; y < myBoard.Size; y++)
                {
                    btnGrid[x, y] = new Button();
                    btnGrid[x, y].Width = buttonSize;
                    btnGrid[x, y].Height = buttonSize;

                    btnGrid[x, y].Click += Grid_Button_Click;
                    mainPanel.Controls.Add(btnGrid[x, y]);
                    btnGrid[x,y].Location = new Point(x * buttonSize, y * buttonSize);
                    btnGrid[x, y].Text = x + "|" + y;

                    btnGrid[x, y].Tag = new Point(x, y);
                }
            }

        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            // get the row and col number of button clicked
            Button clickedButton = (Button)sender;
            Point location = (Point) clickedButton.Tag;

            int x = location.X;
            int y = location.Y;

            Cell currentCell = myBoard.Grid[x, y];

            // determine next legal move
            string piece = cmbPiece.Text;
            myBoard.MarkNextLegalMoves(currentCell, piece);

            // update the text on each button
            for(int i = 0; i < myBoard.Size; i++)
            {
                for(int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j].Text = "";
                    if (myBoard.Grid[i, j].LegalNextMove == true)
                    {
                        btnGrid[i, j].Text = "X";
                    }
                    else if (myBoard.Grid[i, j].CurrentlyOccupied == true)
                    {
                        btnGrid[i, j].Text = piece;
                    }
                }
            }



        }
    }
}
