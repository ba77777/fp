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
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if ((row == 3 && col == 3) || (row == 4 && col == 4))
                    {
                        if (rand == 1)
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
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
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

        public int countCol(Color col)
        {
            int count = 0;
            for(int row=0; row < 8; row++)
            {
                for (int c = 0; c < 8; c++)
                {
                    if (col == Color.Black && squares[row][c].getHasBlack())
                        count++;
                    else if (col == Color.White && squares[row][c].getHasWhite())
                        count++;
                }
            }
            return count;
        }
        private Boolean checkVal(int n){ return n >= 0 && n < 8; }
        
        public Boolean checkIfHasMoves(Color c)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (hasMoves(squares[row][col], c))
                        return true;
                }
            }
            return false;
        }


        private Boolean hasMoves(Square sqr, Color c)
        {
            if ((c == Color.Black && sqr.getHasBlack()) || (c == Color.White && sqr.getHasWhite()))
                return checkUp(sqr) || checkDown(sqr) || checkLeft(sqr) || checkRight(sqr) || checkUpLeft(sqr) || checkUpRight(sqr) || checkDownLeft(sqr) || checkDownRight(sqr);
            return false;
        }

        private Boolean checkUp(Square sqr)
        {
            int row = sqr.getRow();
            int col = sqr.getCol();
            if (checkVal(row - 1) && checkVal(row - 2))// check up
            {
                Square square = squares[row - 1][col];
                if (sqr.getHasBlack() && square.getHasWhite())
                {
                    for (int r = row - 2; checkVal(r); r--)
                    {
                        square = squares[r][col];
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            return true;
                        }
                        else if (square.getHasBlack())
                        {
                            break;
                        }
                    }

                }
                else if (sqr.getHasWhite() && square.getHasBlack())
                {
                    for (int r = row - 2; checkVal(r); r--)
                    {
                        square = squares[r][col];
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            return true;
                        }
                        else if (square.getHasWhite())
                        {
                            break;
                        }
                    }
                }

            }
            return false;
        }
        
        private Boolean checkDown(Square sqr)
        {
            int row = sqr.getRow();
            int col = sqr.getCol();
            if (checkVal(row + 1) && checkVal(row + 2))// check down
            {
                Square square = squares[row + 1][col];
                if (sqr.getHasBlack() && square.getHasWhite())
                {
                    for (int r = row + 2; checkVal(r); r++)
                    {
                        square = squares[r][col];
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            return true;
                        }
                        else if (square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
                else if (sqr.getHasWhite() && square.getHasBlack())
                {
                    for (int r = row + 2; checkVal(r); r++)
                    {
                        square = squares[r][col];
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            return true;
                        }
                        else if (square.getHasWhite())
                        {
                            break;
                        }
                    }
                }
            }
            return false;
        }
        private Boolean checkLeft(Square sqr)
        {
            int row = sqr.getRow();
            int col = sqr.getCol();
            if (checkVal(col - 1) && checkVal(col - 2))// check left
            {
                Square square = squares[row][col - 1];
                if (sqr.getHasBlack() && square.getHasWhite())
                {
                    for (int c = col - 2; checkVal(c); c--)
                    {
                        square = squares[row][c];
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            return true;
                        }
                        else if (square.getHasBlack())
                        {
                            break;
                        }

                    }
                }
                else if (sqr.getHasWhite() && square.getHasBlack())
                {
                    for (int c = col - 2; checkVal(c); c--)
                    {
                        square = squares[row][c];
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            return true;
                        }
                        else if (square.getHasWhite())
                        {
                            break;
                        }

                    }
                }
            }
            return false;
        }
        private Boolean checkRight(Square sqr)
        {
            int row = sqr.getRow();
            int col = sqr.getCol();
            if (checkVal(col + 1) && checkVal(col + 2))// check right
            {
                Square square = squares[row][col + 1];
                if (sqr.getHasBlack() && square.getHasWhite())
                {
                    for (int c = col + 2; checkVal(c); c++)
                    {
                        square = squares[row][c];
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            return true;
                        }
                        else if (square.getHasBlack())
                        {
                            break;
                        }
                    }

                }
                else if (sqr.getHasWhite() && square.getHasBlack())
                {
                    for (int c = col + 2; checkVal(c); c++)
                    {
                        square = squares[row][c];
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            return true;
                        }
                        else if (square.getHasWhite())
                        {
                            break;
                        }
                    }

                }
            }
            return false;
        }
        private Boolean checkUpLeft(Square sqr)
        {
            int row = sqr.getRow();
            int col = sqr.getCol();
            if (checkVal(col - 1) && checkVal(col - 2) && checkVal(row - 1) && checkVal(row - 2))
            {
                Square square = squares[row - 1][col - 1];
                if (sqr.getHasBlack() && square.getHasWhite())
                {
                    for (int c = col - 2, r = row - 2; checkVal(c) && checkVal(r); c--, r--)
                    {
                        square = squares[r][c];
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            return true;
                        }
                        else if (square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
                else if (sqr.getHasWhite() && square.getHasBlack())
                {
                    for (int c = col - 2, r = row - 2; checkVal(c) && checkVal(r); c--, r--)
                    {
                        square = squares[r][c];
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            return true;
                        }
                        else if (square.getHasWhite())
                        {
                            break;
                        }
                    }
                }
            }
            return false;
        }

        private Boolean checkUpRight(Square sqr)
        {
            int row = sqr.getRow();
            int col = sqr.getCol();
            if (checkVal(col + 1) && checkVal(col + 2) && checkVal(row - 1) && checkVal(row - 2))
            {
                Square square =squares[row - 1][col + 1];
                if (sqr.getHasBlack() && square.getHasWhite())
                {
                    for (int c = col + 2, r = row - 2; checkVal(c) && checkVal(r); c++, r--)
                    {
                        square =squares[r][c];
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            return true;
                        }
                        else if (square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
                else if (sqr.getHasWhite() && square.getHasBlack())
                {
                    for (int c = col + 2, r = row - 2; c < 8 && r >= 0; c++, r--)
                    {
                        square =squares[r][c];
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            return true;
                        }
                        else if (square.getHasWhite())
                        {
                            break;
                        }
                    }
                }
            }
            return false;
        }

        private Boolean checkDownLeft(Square sqr)
        {
            int row = sqr.getRow();
            int col = sqr.getCol();
            if (checkVal(col - 1) && checkVal(col - 2) && checkVal(row + 1) && checkVal(row + 2))
            {
                Square square =squares[row + 1][col - 1];
                if (sqr.getHasBlack() && square.getHasWhite())
                {
                    for (int c = col - 2, r = row + 2; checkVal(c) && checkVal(r); c--, r++)
                    {
                        square =squares[r][c];
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            return true;
                        }
                        else if (square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
                else if (sqr.getHasWhite() && square.getHasBlack())
                {
                    for (int c = col - 2, r = row + 2; checkVal(c) && checkVal(r); c--, r++)
                    {
                        square =squares[r][c];
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            return true;
                        }
                        else if (square.getHasWhite())
                        {
                            break;
                        }
                    }
                }
            }
            return false;
        }

        private Boolean checkDownRight(Square sqr)
        {
            int row = sqr.getRow();
            int col = sqr.getCol();
            if (checkVal(col + 1) && checkVal(col + 2) && checkVal(row + 1) && checkVal(row + 2))
            {
                Square square =squares[row + 1][col + 1];
                if (sqr.getHasBlack() && square.getHasWhite())
                {
                    for (int c = col + 2, r = row + 2; checkVal(c) && checkVal(r); c++, r++)
                    {
                        square = squares[r][c];
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            return true;
                        }
                        else if (square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
                else if (sqr.getHasWhite() && square.getHasBlack())
                {
                    for (int c = col + 2, r = row + 2; checkVal(c) && checkVal(r); c++, r++)
                    {
                        square = squares[r][c];
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            return true;
                        }
                        else if (square.getHasWhite())
                        {
                            break;
                        }
                    }
                }
            }
            return false;
        }
        
    }
}
