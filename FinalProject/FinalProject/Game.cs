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
            playP1();
        }

        public void playP1()
        {
            //score1 = board.countCol(p1.getColor());            
            Boolean hasMoves= board.checkIfHasMoves(p1.getColor());
            f.Controls["labelTurn"].Text = p1.getName();
            if (!hasMoves)
            {
                MessageBox.Show("game ended!","End",MessageBoxButtons.OK);
                
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
            timer1.Interval = 250; 
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
            Boolean hasMoves = board.checkIfHasMoves(p2.getColor());
            f.Controls["labelTurn"].Text = p2.getName();
            if (!hasMoves)
            {
                MessageBox.Show("game ended!", "End", MessageBoxButtons.OK);
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
            

            timer2 = new System.Timers.Timer();
            timer2.Interval = 250; 
            timer2.Elapsed += Timer2Elapsed;
            timer2.Start();
        }

        private void Timer2Elapsed(object sender, ElapsedEventArgs e)
        {
            if (board.isP1Turn())
            {
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
    }
}
