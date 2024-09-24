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
        
        public String getDiff()
        {
            return difficulty;
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
        private List<Square> possible_moves(Board board)
        {
            List<Square> possibleMoves = new List<Square>();
            for (int row = 0; row < BOARD_LENGTH; row++)
            {
                for (int column = 0; column < BOARD_LENGTH; column++)
                {
                    Square sqr = Board.GetSquare(row, column);
                    if (sqr.BackColor == col)
                    {
                        possibleMoves.Add(sqr);
                    }
                }
            }
            return possibleMoves;
        }
        private Square ChooseBestSquareToMove(Board board)
        {
            List<Square> occupiedSquares = board.OccupiedSquares;
            Square bestSquare = null;
            int bestScore = int.MinValue;

            foreach (Square square in occupiedSquares)
            {
                int score = EvaluateSquareToMove(board, square);
                if (score > bestScore)
                {
                    bestScore = score;
                    bestSquare = square;
                }
            }

            return bestSquare;
        }
        private int EvaluateSquareToMove(Board board, Square square)
        {
            
            int score = 0;

           
            List<Square> possibleMoves = possible_moves(board);
            score += possibleMoves.Count * 2;

            if (IsCorner(square)) score -= 10;
            if (IsEdge(square)) score -= 5;

            return score;
        }

        private Square ChooseBestDestination(Board board, List<Square> possibleMoves, Square bestSquareToMove)
        {
            Square bestMove = null;
            int bestScore = int.MinValue;

            foreach (Square move in possibleMoves)
            {
                int score = EvaluateMove(board, move, bestSquareToMove);
                if (score > bestScore)
                {
                    bestScore = score;
                    bestMove = move;
                }
            }

            return bestMove;
        }
        private int EvaluateMove(Board board, Square move, Square bestSquareToMove)
        {
            int score = 0;
            if (IsCorner(move)) score += 10;
            if (IsAdjacentToCorner(move)) score -= 5;
            if (IsEdge(move)) score += 3;
            score += CountFlippedPieces(board, move, bestSquareToMove);
            return score;
        }
        private bool IsCorner(Square square)
        {
            int row = square.getRow();
            int col = square.getCol();
            return (row == 0 || row == BOARD_LENGTH - 1) && (col == 0 || col == BOARD_LENGTH - 1);
        }

        private bool IsAdjacentToCorner(Square square)
        {
            int row = square.getRow();
            int col = square.getCol();
            return (row == 0 || row == 1 || row == BOARD_LENGTH - 2 || row == BOARD_LENGTH - 1) &&
                   (col == 0 || col == 1 || col == BOARD_LENGTH - 2 || col == BOARD_LENGTH - 1) &&
                   !IsCorner(square);
        }

        private bool IsEdge(Square square)
        {
            int row = square.getRow();
            int col = square.getCol();
            return row == 0 || row == BOARD_LENGTH - 1 || col == 0 || col == BOARD_LENGTH - 1;
        }

        private int CountFlippedPieces(Board board, Square move, Square bestSquareToMove)
        {
            int move_row = move.getRow();
            int move_col = move.getCol();
            int best_row = bestSquareToMove.getRow();
            int best_col = bestSquareToMove.getCol();
            if(move_row != best_row)
            {
                return Math.Abs(move_row - best_row - 1);
            }
            return Math.Abs(move_col - best_col - 1);
        }
        private void Beginner(Form f, Board board)
        {
            List<Square> occupiedSquares = board.OccupiedSquares, possibleMoves = null;
            int numOf = occupiedSquares.Count();
            Random rnd = new Random();
            int rand = rnd.Next(0, numOf);
            Square.clickButton(occupiedSquares[rand]);
            possibleMoves = possible_moves(board);
            numOf = possibleMoves.Count();
            rand = rnd.Next(0, numOf);
            Square.clickButton(possibleMoves[rand]);
        }


        private void Medium(Form f, Board board)
        {
            Square bestSquareToMove = ChooseBestSquareToMove(board);
            Square.clickButton(bestSquareToMove);
            List<Square> possibleMoves = possible_moves(board);
            Square bestDestination = ChooseBestDestination(board, possibleMoves, bestSquareToMove);
            Square.clickButton(bestDestination);
        }

        private void Hard(Form f, Board board)
        {

        }
    }
}
