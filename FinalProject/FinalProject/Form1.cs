using System;
using System.Windows.Forms;

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
            
            //Square s = new Square(0, 0, true, false, this);
            //Square s1 = new Square(1, 0, false, false, this);
            //Square s2 = new Square(0, 1, false, true, this);
        }
    }
}
