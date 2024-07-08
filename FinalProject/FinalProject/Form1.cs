using System;
using System.Windows.Forms;
using System.Drawing;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        private Board board;
        private string playerName1;
        private string playerName2;
        private Boolean pvp;
        private Boolean easyBot;

        public Form1(string name1, string name2, Boolean pvp, Boolean esBot)
        {
            InitializeComponent();
            playerName1 = name1;
            playerName2 = name2;
            this.pvp = pvp;
            easyBot = esBot;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            board = new Board(this);
            Player p1, p2;
            if (pvp)//אם זה שחקן נגד שחקן
            {
                bool isWhiteFirst = board.isWhiteFirst();
                if (isWhiteFirst)
                {
                    p1 = new Player(playerName1, Color.White);
                    p2 = new Player(playerName2, Color.Black);
                }
                else
                {
                    p1 = new Player(playerName1, Color.Black);
                    p2 = new Player(playerName2, Color.White);
                }
            }
            else//vs bot
            {
                if (easyBot){//if it easy bot
                    p1= new Player(playerName1, Color.White);
                    p2= new Bot(playerName2, Color.Black);
                }
                else//hard bot
                {
                    p1 = new Player(playerName1, Color.White);
                    p2 = new Player(playerName2, Color.Black);
                }    
            }
            Game g = new Game(p1, p2, board, this);
        }

        private void btn_saveBoard(object sender, EventArgs e)
        {

        }
    }
}
