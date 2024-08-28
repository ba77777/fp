using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    class Cpu : Player
    {
        private String difficulty = "";
        private const int BOARD_LENGTH = 8;
        public Cpu(String name, Color col, string difficulty) : base(name, col)
        {
            this.difficulty = difficulty;
        }

        public void playCpu(Form f, Board board)
        {
            if (difficulty == "B")
                Beginner(f, board);
            else if (difficulty == "M")
                Medium(f, board);
            else
                Hard(f, board);
        }

        private void Beginner(Form f, Board board)
        {
            List<Square> possible_moves = board.possibleMoves, possibleEat = new List<Square>();
            int numOf = possible_moves.Count();
            Random rnd = new Random();
            int rand = rnd.Next(0, numOf);
            Square.clickButton(possible_moves[rand]);
            for(int row = 0; row < BOARD_LENGTH; row++)
            {
                for(int column = 0; column < BOARD_LENGTH; column++)
                {
                    Square sqr = Board.GetSquare(row, column);
                    if (sqr.BackColor == col)
                    {
                        possibleEat.Add(sqr);
                    }
                }
            }
            numOf = possibleEat.Count();
            rand = rnd.Next(0, numOf);
            Square.clickButton(possibleEat[rand]);
        }

        private void Medium(Form f, Board board)
        {

        }

        private void Hard(Form f, Board board)
        {

        }
    }
}
