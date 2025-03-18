using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Timers;

namespace FinalProject
{
    class Game
    {
        const int DELAY = 250;
        private Player p1, p2;
        private Board board;
        private Form f;
        private System.Timers.Timer timer1 = new System.Timers.Timer();
        private System.Timers.Timer timer2 = new System.Timers.Timer();
        private int score1 = 0, score2 = 0;
        public Game(Player p1, Player p2, Board b, Form f)
        {
            this.p1 = p1;
            this.p2 = p2;
            board = b;
            this.f = f;
            f.Controls["labelP1Name"].Text = p1.getName();
            f.Controls["labelP1Name"].BackColor = p1.getColor();
            f.Controls["labelP1Name"].ForeColor = p2.getColor();
            f.Controls["score_label1"].BackColor = p1.getColor();
            f.Controls["score_label1"].ForeColor = p2.getColor();
            f.Controls["labelP2Name"].Text = p2.getName();
            f.Controls["labelP2Name"].BackColor = p2.getColor();
            f.Controls["labelP2Name"].ForeColor = p1.getColor();
            f.Controls["score_label2"].BackColor = p2.getColor();
            f.Controls["score_label2"].ForeColor = p1.getColor();
            playP1();
        }

        public void playP1()
        {
            score1 = board.countCol(p1.getColor());
            score2 = board.countCol(p2.getColor());
            Boolean hasMoves= board.checkIfHasMoves(p1.getColor());      
            f.Controls["score_label1"].Text = "score:\n" + score1.ToString();
            f.Controls["score_label2"].Text = "score:\n" + score2.ToString();
            if (score1 == 0 || !hasMoves)
            {
                EndGame();
            }
            else if (p1.getColor() == Color.White)
            {
                board.enableColor("white");
                board.disableColor("black");
            }
            else
            {
                board.enableColor("black");
                board.disableColor("white");
            }
           

            timer1 = new System.Timers.Timer();
            timer1.Interval = DELAY; 
            timer1.Elapsed += Timer1Elapsed;
            timer1.Start();
        }

        private void Timer1Elapsed(object sender, ElapsedEventArgs e)
        {
            if (!board.isP1Turn())
            {
                timer1.Stop();
                if (f.IsHandleCreated && !f.IsDisposed)
                {
                    f.Invoke((MethodInvoker)delegate
                    {
                        playP2();
                    });
                }
            }
            
        }

        public void playP2()
        {
            score1 = board.countCol(p1.getColor());
            score2 = board.countCol(p2.getColor());
            Boolean hasMoves = board.checkIfHasMoves(p2.getColor());
            f.Controls["score_label1"].Text = "score:\n" + score1.ToString();
            f.Controls["score_label2"].Text = "score:\n" + score2.ToString();
            if (score2 == 0 || !hasMoves)
            {
                
                EndGame();
            }
            else if (p2.getColor() == Color.White)
            {
                board.enableColor("white");
                board.disableColor("black");
            }
            else
            {
                board.enableColor("black");
                board.disableColor("white");
            }
            
            if(p2 is Cpu)
            {
                Cpu cpuInstance = p2 as Cpu;
                cpuInstance.playCpu(board);
                playP1();
            }
            else
            {
                timer2 = new System.Timers.Timer();
                timer2.Interval = DELAY;
                timer2.Elapsed += Timer2Elapsed;
                timer2.Start();
            }
        }

        private void Timer2Elapsed(object sender, ElapsedEventArgs e)
        {
            if (board.isP1Turn())
            {
                if(!(p2 is Cpu))
                    timer2.Stop();
                if (f.IsHandleCreated && !f.IsDisposed)
                {
                    f.Invoke((MethodInvoker)delegate
                    {
                        playP1();
                    });
                }


            }

        }
        private void EndGame()
        {
            MessageBox.Show("game ended!", "End", MessageBoxButtons.OK);
            String msg = "";
            if (score1 > score2)
            {
                msg = p1.getName().ToUpper() + " IS THE WINNER CONGRATS!\nDo you want to start another game? (if you answer no the game will close)";
            }
            else if (score1 < score2)
            {
                msg = p2.getName().ToUpper() + " IS THE WINNER CONGRATS!\nDo you want to start another game? (if you answer no the game will close)";
            }
            else
            {
                msg = "IT'S A BORE DRAW! \nDo you want to start another game? (if you answer no the game will close)";
            }
            DialogResult res = MessageBox.Show(msg, "End", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                HomeForm hf = new HomeForm();
                f.Close();
                hf.Show();

            }
            else
            {
                Application.Exit();
            }
        }
        public String getGameData()
        {
            String res = "";
            res += "P1 name-" + p1.getName() + " " + p1.getColor() + "\n";
            if(p2 is Cpu)
            {
                Cpu cpuInstance = p2 as Cpu;
                res += "P2 name-" + p2.getName() + " " + p2.getColor() + " " + cpuInstance.getDiff() + "\n";
            }
            else
            {
                res += "P2 name-" + p2.getName() + " " + p2.getColor() + "\n";
            }
            return res;
        }
    }
}
