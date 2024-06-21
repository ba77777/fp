using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;


namespace FinalProject
{
    public partial class Form1 : Form
    {
        private Board b;
        private string playerName1;
        private string playerName2;

        public Form1(string name1, string name2)
        {
            InitializeComponent();
            this.playerName1 = name1;
            this.playerName2 = name2;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            b = new Board(this);
            bool isWhiteFirst = b.isWhiteFirst();
            Player p1, p2;
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

            Game g = new Game(p1, p2, b, this);
        }

        private void btn_saveBoard(object sender, EventArgs e)
        {
            string fileName = (CountFiles() + 1).ToString() + "_" + DateTime.Now.ToString("dd-MM_HH-mm") + ".txt";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SavesFiles");
            string filePath = Path.Combine(path, fileName);
            string whatToSave = "";
            File.WriteAllText(filePath, whatToSave);

            this.Close();
        }

        private int CountFiles()
        {
            return Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"SavesFiles")).Length;
        }

        
    }
}
