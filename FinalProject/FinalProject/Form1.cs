using System;
using System.Windows.Forms;
using System.Drawing;

using System.IO;
using System.Windows.Forms;


namespace FinalProject
{
    public partial class Form1 : Form
    {
        const int BOARD_LENGTH = 8;
        private Board b;
        private string playerName1;
        private string playerName2;
        private Game g;
        private Boolean sentFromDefault = false;
        public Form1()
        {
            InitializeComponent();
            sentFromDefault = true;
            
        }

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

            
            if(sentFromDefault)
                btnLoad_Click(this, EventArgs.Empty);
            else
                g = new Game(p1, p2, b, this);
        }

        private void btn_saveBoard(object sender, EventArgs e)
        {
           
            SaveGameForm saveForm = new SaveGameForm();
            saveForm.OnSaveSlotSelected += slot =>
            {
                SaveGame(slot);
                saveForm.RefreshButtonTexts();
                saveForm.Close(); 
            };
            saveForm.ShowDialog(this); 
        }
    

        private void SaveGame(int slot)
        {

            string filePath = $"Saves/{slot}.txt";
            if (File.Exists(filePath))
            {
                DialogResult result = MessageBox.Show("This slot is already occupied. Do you want to overwrite it?", "Confirm Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            String boardData = b.getButtonsData();
            String gameData = g.getGameData();
            StreamWriter writer = new StreamWriter(filePath);
            writer.WriteLine("Saved: "+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            writer.WriteLine(gameData);
            writer.WriteLine(boardData);
            writer.Close();
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SaveGameForm saveForm = new SaveGameForm();
            saveForm.OnSaveSlotSelected += slot =>
            {
                LoadGame(slot);
                saveForm.Close();
            };
            saveForm.ShowDialog();
        }

        private void LoadGame(int slot)
        {

            string filePath = $"Saves/{slot}.txt";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("You chose an empty slot. Try choosing another slot or saving a game at first.", "No game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StreamReader reader = new StreamReader(filePath);
            reader.ReadLine();
            String p1 = reader.ReadLine();
            String p2 = reader.ReadLine();
            reader.ReadLine();
            String isP1first = reader.ReadLine();
            isP1first = isP1first.Split(' ')[1];

            for (int i = 0; i < BOARD_LENGTH * BOARD_LENGTH; i++)
            {
                String btn = reader.ReadLine();
                int row = int.Parse((btn.Split(' ')[1]).Split('-')[1]);
                int col = int.Parse((btn.Split(' ')[2]).Split('-')[1]);
                Boolean hasWhite = bool.Parse((btn.Split(' ')[3]).Split('-')[1]);
                Boolean hasBlack = bool.Parse((btn.Split(' ')[4]).Split('-')[1]);
                Square sqr = Board.GetSquare(row, col);
                if (i == 0)
                    sqr.resetBgColors();
                sqr.setHasWhite(hasWhite);
                sqr.setHasBlack(hasBlack);
                sqr.drawSolider();
                
            }
            reader.Close();

            String p1Name, p1Col, p2Name, p2Col;
            p1Name = (p1.Split(' ')[1]).Split('-')[1];
            p1Col = (p1.Split(' ')[3]);
            p1Col = p1Col.Substring(1, p1Col.Length - 2);
            p2Name = (p2.Split(' ')[1]).Split('-')[1];
            p2Col = (p2.Split(' ')[3]);
            p2Col = p2Col.Substring(1, p2Col.Length - 2);
            
            Player P1 = new Player(p1Name, Color.FromName(p1Col));
            Player P2 = new Player(p2Name, Color.FromName(p2Col));
            g = new Game(P1, P2, b, this);
            if (!bool.Parse(isP1first))
                Square.changeTurn();
        }

        
    }
}
