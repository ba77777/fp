using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    class Square : Button
    {
        private int row;
        private int col;
        private Boolean hasWhite;
        private Boolean hasBlack;
        private Form currentForm;
        //das


        public Square(int row, int col, Boolean hasWhite, Boolean hasBlack, Form f1)
        {
            this.row = row;
            this.col = col;
            this.hasWhite = hasWhite;
            this.hasBlack = hasBlack;
            currentForm = f1;
            drawSquare();
        }

        public int getRow()
        {
            return row;
        }

        public int getCol()
        {
            return col;
        }

        public Boolean getHasWhite()
        {
            return hasWhite;
        }

        public void setHasWhite(Boolean b)
        {
            hasWhite = b;
        }

        public Boolean getHasBlack()
        {
            return hasBlack;
        }

        public void setHasBlack(Boolean b)
        {
            hasBlack = b;
        }

        private void drawSquare()
        {
            this.Size = new Size(50, 50);
            this.Location = new Point(250 + 50 * col, 50 + 50 * row);
            this.BackColor = Color.FromArgb(0, 175, 0);
            this.FlatStyle = FlatStyle.Flat;
            this.Enabled = true;
            this.MouseClick += new MouseEventHandler(buttons_MouseClick);
            currentForm.Controls.Add(this);

            if (hasBlack || hasWhite)
            {
                drawSolider();
            }
        }

        public void drawSolider()
        {
            this.BackgroundImage = null;
            if (hasBlack)
            {

                this.BackgroundImage = Image.FromFile("pics\\black.png");
            }
            else if (hasWhite)
            {
                this.BackgroundImage = Image.FromFile("pics\\white.png");
            }

            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void buttons_MouseClick(object sender, MouseEventArgs e)
        {

            if (hasBlack || hasWhite)
            {
                resetBgColors();
                markOptions();
            }
            else if (BackColor == Color.White)
            {
                hasWhite = true;
                drawSolider();
                redrawEatenSoliders();
                resetBgColors();
            }
            else if (BackColor == Color.Black)
            {
                hasBlack = true;
                drawSolider();
                redrawEatenSoliders();
                resetBgColors();
            }
            //MessageBox.Show($"Clicked Square: {row}, {col}, {hasBlack}, {hasWhite}");

        }

        private Boolean checkVal(int val)
        {
            return val >= 0 && val < 8;
        }
        private void resetBgColors()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Square square = Board.GetSquare(i, j);
                    square.BackColor = Color.FromArgb(0, 175, 0);
                }
            }
        }

        private void markOptions()
        {
            markUp();
            markDown();
            markLeft();
            markRight();
            markUpLeft();
            markUpRight();
            markDownLeft();
            markDownRight();
        }

        private void markUp()
        {
            if (checkVal(row - 1) && checkVal(row - 2))// check up
            {
                Square square = Board.GetSquare(row - 1, col);
                if (this.hasBlack && square.getHasWhite())
                {
                    for (int r = row - 2; checkVal(r); r--)
                    {
                        square = Board.GetSquare(r, col);
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            square.BackColor = Color.Black;
                            break;
                        }
                        else if (square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
                else if (this.hasWhite && square.getHasBlack())
                {
                    for (int r = row - 2; checkVal(r); r--)
                    {
                        square = Board.GetSquare(r, col);
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            square.BackColor = Color.White;
                            break;
                        }
                        else if (square.getHasWhite())
                        {
                            break;
                        }
                    }
                }
            }
        }
        private void markDown()
        {
            if (checkVal(row + 1) && checkVal(row + 2))// check down
            {
                Square square = Board.GetSquare(row + 1, col);
                if (this.hasBlack && square.getHasWhite())
                {
                    for (int r = row + 2; checkVal(r); r++)
                    {
                        square = Board.GetSquare(r, col);
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            square.BackColor = Color.Black;
                            break;
                        }
                        else if (square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
                else if (this.hasWhite && square.getHasBlack())
                {
                    for (int r = row + 2; checkVal(r); r++)
                    {
                        square = Board.GetSquare(r, col);
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            square.BackColor = Color.White;
                            break;
                        }
                        else if (square.getHasWhite())
                        {
                            break;
                        }
                    }
                }
            }
        }
        private void markLeft()
        {
            if (checkVal(col - 1) && checkVal(col - 2))// check left
            {
                Square square = Board.GetSquare(row, col - 1);
                if (this.hasBlack && square.getHasWhite())
                {
                    for (int c = col - 2; checkVal(c); c--)
                    {
                        square = Board.GetSquare(row, c);
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            square.BackColor = Color.Black;
                            break;
                        }
                        else if (square.getHasBlack())
                        {
                            break;
                        }

                    }
                }
                else if (this.hasWhite && square.getHasBlack())
                {
                    for (int c = col - 2; checkVal(c); c--)
                    {
                        square = Board.GetSquare(row, c);
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            square.BackColor = Color.White;
                            break;
                        }
                        else if (square.getHasWhite())
                        {
                            break;
                        }

                    }
                }
            }
        }
        private void markRight()
        {
            if (checkVal(col + 1) && checkVal(col + 2))// check right
            {
                Square square = Board.GetSquare(row, col + 1);
                if (this.hasBlack && square.getHasWhite())
                {
                    for (int c = col + 2; checkVal(c); c++)
                    {
                        square = Board.GetSquare(row, c);
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            square.BackColor = Color.Black;
                            break;
                        }
                        else if (square.getHasBlack())
                        {
                            break;
                        }
                    }

                }
                else if (this.hasWhite && square.getHasBlack())
                {
                    for (int c = col + 2; checkVal(c); c++)
                    {
                        square = Board.GetSquare(row, c);
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            square.BackColor = Color.White;
                            break;
                        }
                        else if (square.getHasWhite())
                        {
                            break;
                        }
                    }

                }
            }
        }
        private void markUpLeft()
        {
            if (checkVal(col - 1) && checkVal(col - 2) && checkVal(row - 1) && checkVal(row - 2))
            {
                Square square = Board.GetSquare(row - 1, col - 1);
                if (this.hasBlack && square.getHasWhite())
                {
                    for (int c = col - 2, r = row - 2; checkVal(c) && checkVal(r); c--, r--)
                    {
                        square = Board.GetSquare(r, c);
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            square.BackColor = Color.Black;
                            break;
                        }
                        else if (square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
                else if (this.hasWhite && square.getHasBlack())
                {
                    for (int c = col - 2, r = row - 2; checkVal(c) && checkVal(r); c--, r--)
                    {
                        square = Board.GetSquare(r, c);
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            square.BackColor = Color.White;
                            break;
                        }
                        else if (square.getHasWhite())
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void markUpRight()
        {
            if (checkVal(col + 1) && checkVal(col + 2) && checkVal(row - 1) && checkVal(row - 2))
            {
                Square square = Board.GetSquare(row - 1, col + 1);
                if (this.hasBlack && square.getHasWhite())
                {
                    for (int c = col + 2, r = row - 2; checkVal(c) && checkVal(r); c++, r--)
                    {
                        square = Board.GetSquare(r, c);
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            square.BackColor = Color.Black;
                            break;
                        }
                        else if (square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
                else if (this.hasWhite && square.getHasBlack())
                {
                    for (int c = col + 2, r = row - 2; c < 8 && r >= 0; c++, r--)
                    {
                        square = Board.GetSquare(r, c);
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            square.BackColor = Color.White;
                            break;
                        }
                        else if (square.getHasWhite())
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void markDownLeft()
        {
            if (checkVal(col - 1) && checkVal(col - 2) && checkVal(row + 1) && checkVal(row + 2))
            {
                Square square = Board.GetSquare(row + 1, col - 1);
                if (this.hasBlack && square.getHasWhite())
                {
                    for (int c = col - 2, r = row + 2; checkVal(c) && checkVal(r); c--, r++)
                    {
                        square = Board.GetSquare(r, c);
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            square.BackColor = Color.Black;
                            break;
                        }
                        else if (square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
                else if (this.hasWhite && square.getHasBlack())
                {
                    for (int c = col - 2, r = row + 2; checkVal(c) && checkVal(r); c--, r++)
                    {
                        square = Board.GetSquare(r, c);
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            square.BackColor = Color.White;
                            break;
                        }
                        else if (square.getHasWhite())
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void markDownRight()
        {
            if (checkVal(col + 1) && checkVal(col + 2) && checkVal(row + 1) && checkVal(row + 2))
            {
                Square square = Board.GetSquare(row + 1, col + 1);
                if (this.hasBlack && square.getHasWhite())
                {
                    for (int c = col + 2, r = row + 2; checkVal(c) && checkVal(r); c++, r++)
                    {
                        square = Board.GetSquare(r, c);
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            square.BackColor = Color.Black;
                            break;
                        }
                        else if (square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
                else if (this.hasWhite && square.getHasBlack())
                {
                    for (int c = col + 2, r = row + 2; checkVal(c) && checkVal(r); c++, r++)
                    {
                        square = Board.GetSquare(r, c);
                        if (!square.getHasWhite() && !square.getHasBlack())
                        {
                            square.BackColor = Color.White;
                            break;
                        }
                        else if (square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void redrawEatenSoliders()
        {
            redrawRight();
            redrawLeft();
            redrawUp();
            redrawDown();
            redrawRightUp();
            redrawLeftUp();
            redrawRightDown();
            redrawLeftDown();
        }

        private void redrawRight()
        {
            if (checkVal(col + 1) && checkVal(col + 2))
            {
                Square square = Board.GetSquare(row, col + 1);
                if (this.hasBlack && square.getHasWhite())
                {

                    for (int c = col + 2; checkVal(c); c++)
                    {
                        square = Board.GetSquare(row, c);
                        if (square.getHasBlack())
                        {
                            for (int i = square.col - 1; i > this.col; i--)
                            {
                                square = Board.GetSquare(row, i);
                                square.hasBlack = true;
                                square.hasWhite = false;
                                square.drawSolider();
                            }
                            break;
                        }
                        else if (!square.getHasWhite())
                        {
                            break;
                        }

                    }

                }
                else if (this.hasWhite && square.getHasBlack())
                {

                    for (int c = col + 2; checkVal(c); c++)
                    {
                        square = Board.GetSquare(row, c);
                        if (square.getHasWhite())
                        {
                            for (int i = square.col - 1; i > this.col; i--)
                            {
                                square = Board.GetSquare(row, i);
                                square.hasBlack = false;
                                square.hasWhite = true;
                                square.drawSolider();
                            }
                            break;
                        }
                        else if (!square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
            }
        }
        private void redrawLeft() 
        {
            if (checkVal(col - 1) && checkVal(col - 2))
            {
                Square square = Board.GetSquare(row, col - 1);
                if (this.hasBlack && square.getHasWhite())
                {

                    for (int c = col - 2; checkVal(c); c--)
                    {
                        square = Board.GetSquare(row, c);
                        if (square.getHasBlack())
                        {
                            for (int i = square.col + 1; i < this.col; i++)
                            {
                                square = Board.GetSquare(row, i);
                                square.hasBlack = true;
                                square.hasWhite = false;
                                square.drawSolider();
                            }
                            break;
                        }
                        else if (!square.getHasWhite())
                        {
                            break;
                        }

                    }

                }
                else if (this.hasWhite && square.getHasBlack())
                {

                    for (int c = col - 2; checkVal(c); c--)
                    {
                        square = Board.GetSquare(row, c);
                        if (square.getHasWhite())
                        {
                            for (int i = square.col + 1; i < this.col; i++)
                            {
                                square = Board.GetSquare(row, i);
                                square.hasBlack = false;
                                square.hasWhite = true;
                                square.drawSolider();
                            }
                            break;
                        }
                        else if (!square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
            }
        }
        private void redrawUp() 
        {
            if (checkVal(row - 1) && checkVal(row - 2))
            {
                Square square = Board.GetSquare(row -1, col);
                if (this.hasBlack && square.getHasWhite())
                {

                    for (int r = row - 2; checkVal(r); r--)
                    {
                        square = Board.GetSquare(r, col);
                        if (square.getHasBlack())
                        {
                            for (int i = square.row + 1; i < this.row; i++)
                            {
                                square = Board.GetSquare(i, col);
                                square.hasBlack = true;
                                square.hasWhite = false;
                                square.drawSolider();
                            }
                            break;
                        }
                        else if (!square.getHasWhite())
                        {
                            break;
                        }
                    }

                }
                else if (this.hasWhite && square.getHasBlack())
                {

                    for (int r = row - 2; checkVal(r); r--)
                    {
                        square = Board.GetSquare(r, col);
                        if (square.getHasWhite())
                        {
                            for (int i = square.row + 1; i < this.row; i++)
                            {
                                square = Board.GetSquare(i, col);
                                square.hasBlack = false;
                                square.hasWhite = true;
                                square.drawSolider();
                            }
                            break;
                        }
                        else if (!square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
            }
        }
        private void redrawDown()
        {
            if (checkVal(row + 1) && checkVal(row + 2))
            {
                Square square = Board.GetSquare(row + 1, col);
                if (this.hasBlack && square.getHasWhite())
                {

                    for (int r = row + 2; checkVal(r); r++)
                    {
                        square = Board.GetSquare(r, col);
                        if (square.getHasBlack())
                        {
                            for (int i = square.row - 1; i > this.row; i--)
                            {
                                square = Board.GetSquare(i, col);
                                square.hasBlack = true;
                                square.hasWhite = false;
                                square.drawSolider();
                            }
                            break;
                        }
                        else if (!square.getHasWhite())
                        {
                            break;
                        }

                    }

                }
                else if (this.hasWhite && square.getHasBlack())
                {

                    for (int r = row + 2; checkVal(r); r++)
                    {
                        square = Board.GetSquare(r, col);
                        if (square.getHasWhite())
                        {
                            for (int i = square.row - 1; i > this.row; i--)
                            {
                                square = Board.GetSquare(i, col);
                                square.hasBlack = false;
                                square.hasWhite = true;
                                square.drawSolider();
                            }
                            break;
                        }
                        else if (!square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
            }
        }
        private void redrawRightUp() 
        {
            if (checkVal(col + 1) && checkVal(col + 2) && checkVal(row - 1) && checkVal(row - 2))
            {
                Square square = Board.GetSquare(row - 1, col + 1);
                if (this.hasBlack && square.getHasWhite())
                {

                    for (int c = col + 2, r = row - 2; checkVal(c) && checkVal(r); c++,r--)
                    {
                        square = Board.GetSquare(r, c);
                        if (square.getHasBlack())
                        {
                            for (int x = square.col - 1, y = square.row + 1; x > this.col && y < this.row; x--,y++)
                            {
                                square = Board.GetSquare(y, x);
                                square.hasBlack = true;
                                square.hasWhite = false;
                                square.drawSolider();
                            }
                            break;
                        }
                        else if (!square.getHasWhite())
                        {
                            break;
                        }

                    }

                }
                else if (this.hasWhite && square.getHasBlack())
                {

                    for (int c = col + 2, r = row - 2; checkVal(c) && checkVal(r); c++, r--)
                    {
                        square = Board.GetSquare(r, c);
                        if (square.getHasWhite())
                        {
                            for (int x = square.col - 1, y = square.row + 1; x > this.col && y < this.row; x--, y++)
                            {
                                square = Board.GetSquare(y, x);
                                square.hasBlack = false;
                                square.hasWhite = true;
                                square.drawSolider();
                            }
                            break;
                        }
                        else if (!square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
            }
        }
        private void redrawLeftUp() 
        {
            if (checkVal(col - 1) && checkVal(col - 2) && checkVal(row - 1) && checkVal(row - 2))
            {
                Square square = Board.GetSquare(row - 1, col - 1);
                if (this.hasBlack && square.getHasWhite())
                {

                    for (int c = col - 2, r = row - 2; checkVal(c) && checkVal(r); c--, r--)
                    {
                        square = Board.GetSquare(r, c);
                        if (square.getHasBlack())
                        {
                            for (int x = square.col + 1, y = square.row + 1; x < this.col && y < this.row; x++, y++)
                            {
                                square = Board.GetSquare(y, x);
                                square.hasBlack = true;
                                square.hasWhite = false;
                                square.drawSolider();
                            }
                            break;
                        }
                        else if (!square.getHasWhite())
                        {
                            break;
                        }

                    }

                }
                else if (this.hasWhite && square.getHasBlack())
                {

                    for (int c = col - 2, r = row - 2; checkVal(c) && checkVal(r); c--, r--)
                    {
                        square = Board.GetSquare(r, c);
                        if (square.getHasWhite())
                        {
                            for (int x = square.col + 1, y = square.row + 1; x < this.col && y < this.row; x++, y++)
                            {
                                square = Board.GetSquare(y, x);
                                square.hasBlack = false;
                                square.hasWhite = true;
                                square.drawSolider();
                            }
                            break;
                        }
                        else if (!square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
            }
        }
    
        private void redrawRightDown() 
        {
            if (checkVal(col + 1) && checkVal(col + 2) && checkVal(row + 1) && checkVal(row + 2))
            {
                Square square = Board.GetSquare(row + 1, col + 1);
                if (this.hasBlack && square.getHasWhite())
                {

                    for (int c = col + 2, r = row + 2; checkVal(c) && checkVal(r); c++, r++)
                    {
                        square = Board.GetSquare(r, c);
                        if (square.getHasBlack())
                        {
                            for (int x = square.col - 1, y = square.row - 1; x > this.col && y > this.row; x--, y--)
                            {
                                square = Board.GetSquare(y, x);
                                square.hasBlack = true;
                                square.hasWhite = false;
                                square.drawSolider();
                            }
                            break;
                        }
                        else if (!square.getHasWhite())
                        {
                            break;
                        }

                    }

                }
                else if (this.hasWhite && square.getHasBlack())
                {

                    for (int c = col + 2, r = row + 2; checkVal(c) && checkVal(r); c++, r++)
                    {
                        square = Board.GetSquare(r, c);
                        if (square.getHasWhite())
                        {
                            for (int x = square.col - 1, y = square.row - 1; x > this.col && y > this.row; x--, y--)
                            {
                                square = Board.GetSquare(y, x);
                                square.hasBlack = false;
                                square.hasWhite = true;
                                square.drawSolider();
                            }
                            break;
                        }
                        else if (!square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
            }
        }
        private void redrawLeftDown() 
        {
            if (checkVal(col - 1) && checkVal(col - 2) && checkVal(row + 1) && checkVal(row + 2))
            {
                Square square = Board.GetSquare(row + 1, col - 1);
                if (this.hasBlack && square.getHasWhite())
                {

                    for (int c = col - 2, r = row + 2; checkVal(c) && checkVal(r); c--, r++)
                    {
                        square = Board.GetSquare(r, c);
                        if (square.getHasBlack())
                        {
                            for (int x = square.col + 1, y = square.row - 1; x < this.col && y > this.row; x++, y--)
                            {
                                square = Board.GetSquare(y, x);
                                square.hasBlack = true;
                                square.hasWhite = false;
                                square.drawSolider();
                            }
                            break;
                        }
                        else if (!square.getHasWhite())
                        {
                            break;
                        }

                    }

                }
                else if (this.hasWhite && square.getHasBlack())
                {

                    for (int c = col - 2, r = row + 2; checkVal(c) && checkVal(r); c--, r++)
                    {
                        square = Board.GetSquare(r, c);
                        if (square.getHasWhite())
                        {
                            for (int x = square.col + 1, y = square.row - 1; x < this.col && y > this.row; x++, y--)
                            {
                                square = Board.GetSquare(y, x);
                                square.hasBlack = false;
                                square.hasWhite = true;
                                square.drawSolider();
                            }
                            break;
                        }
                        else if (!square.getHasBlack())
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
    