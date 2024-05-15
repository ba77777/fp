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
            //Boolean = b.checkIfGameOver(p1.getColor());// a function in the Board class
            //that checks if there r any possible moves to do 
            f.Controls["labelTurn"].Text = p1.getName();
            if (p1.getColor() == Color.White)
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
                f.Invoke((MethodInvoker)delegate
                {
                    playP2();
                });
            }
            
        }

        public void playP2()
        {
            //Boolean = b.checkIfGameOver(p1.getColor());// a function in the Board class
            //that checks if there r any possible moves to do 
            f.Controls["labelTurn"].Text = p2.getName();
            if (p2.getColor() == Color.White)
            {
                board.enableColor("white");
                board.disableColor("black");
            }
            else
            {
                board.enableColor("black");
                board.disableColor("white");
            }
            //"alert P2 turn in the form"

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
                f.Invoke((MethodInvoker)delegate
                {
                    playP1();
                });

               
            }

        }
    }
}
