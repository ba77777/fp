using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void playerVplayer_Click(object sender, EventArgs e)
        {
            playersName form = new playersName(true,false);
            form.Show();
        }

        private void howToPlay_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Reversi");
        }

        private void playerVbot_Click(object sender, EventArgs e)
        {
            if (!checkBoxEasy.Checked && !checkBoxHard.Checked)
                MessageBox.Show("Please select a difficulty level");
            else if (checkBoxEasy.Checked)
            {
                playersName form = new playersName(false,true);
                form.Show();
            }
            else if (checkBoxHard.Checked)
            {
                playersName form = new playersName(false,false);
                form.Show();
            }
        }

        private void easyClick(object sender, EventArgs e)
        {;
            checkBoxHard.Checked = false;
        }

        private void hardClick(object sender, EventArgs e)
        {
            checkBoxEasy.Checked = false;
        }
    }
}
