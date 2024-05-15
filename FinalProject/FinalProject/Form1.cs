using System;
using System.Windows.Forms;
using System.Drawing;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        private Board b;
       

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
            b = new Board(this);
            Boolean isWhiteFirst = b.isWhiteFirst();
            Player p1, p2;
            if (isWhiteFirst)
            {
                p1 = new Player("name", Color.White);
                p2 = new Player("name2", Color.Black);
            }
            else
            {
                p1 = new Player("name", Color.Black);
                p2 = new Player("name2", Color.White);
            }

            Game g = new Game(p1, p2, b, this);
            //Square s = new Square(0, 0, true, false, this);
            //Square s1 = new Square(1, 0, false, false, this);
            //Square s2 = new Square(0, 1, false, true, this);
        }
    }
}
