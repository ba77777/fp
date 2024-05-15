using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace FinalProject
{
    class Board
    {
        private static Square[][] squares = new Square[8][];
        private Form currentForm;
        
        public Board(Form f1)
        {
            for (int i = 0; i < squares.Length; i++)
            {
                squares[i] = new Square[8];
            }

            currentForm = f1;
            
            CreateNewBoard();
        }

        public static Square GetSquare(int row, int col)
        {
            return squares[row][col];
        }

        

        private void CreateNewBoard()
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, 3);
            for (int row=0; row<8; row++)
            {
                for(int col=0; col<8; col++)
                {
                    if ((row == 3 && col == 3) || (row == 4 && col == 4))
                    {
                        if(rand == 1)
                        {
                            squares[row][col] = new Square(row, col, false, true, currentForm);
                        }
                        else
                        {
                            squares[row][col] = new Square(row, col, true, false, currentForm);
                        }
                    }
                    else if ((row == 3 && col == 4) || (row == 4 && col == 3))
                    {
                        if (rand == 1)
                        {
                            squares[row][col] = new Square(row, col, true, false, currentForm);
                        }
                        else
                        {
                            squares[row][col] = new Square(row, col, false, true, currentForm);
                        }
                    }

                    else
                    {
                        squares[row][col] = new Square(row, col, false, false, currentForm);
                    }
                    
                    
                }
            }
        }
        public Boolean isP1Turn()
        {
            return squares[0][0].getTurn() % 2 == 1;
        }
        public Boolean isWhiteFirst()
        {
            return squares[3][3].getHasWhite();
        } 
        public void disableColor(String color)
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (color == "black")
                    {
                        if (squares[i][j].getHasBlack())
                        {
                            squares[i][j].Enabled = false;
                        }
                    }
                    else
                    {
                        if (squares[i][j].getHasWhite())
                        {
                            squares[i][j].Enabled = false;
                        }
                    }
                }
            }
        }

        public void enableColor(String color)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (color == "black")
                    {
                        if (squares[i][j].getHasBlack())
                        {
                            squares[i][j].Enabled = true;
                        }
                    }
                    else
                    {
                        if (squares[i][j].getHasWhite())
                        {
                            squares[i][j].Enabled = true;
                        }
                    }
                }
            }
        }

        
    }
}
