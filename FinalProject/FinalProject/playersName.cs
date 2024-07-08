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
    public partial class playersName : Form
    {
        private Boolean pvp = true;
        private Boolean esayBot;

        public playersName(Boolean pvp, Boolean esBot)
        {
            InitializeComponent();
            this.pvp = pvp;
            esayBot = esBot;
            if (!pvp)
            {
                textName2.Text = "Bot";
                textName2.ReadOnly = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form;
            if (pvp)
                form = new Form1(textName1.Text, textName2.Text, true, false);//שחקן נגד שחקן
            else
                if(esayBot)
                    form = new Form1(textName1.Text, textName2.Text, false, true);//בוט קל
                else
                    form = new Form1(textName1.Text, textName2.Text, false, false);//בוט קשה

            form.Show();
            Close();
        }
    }
}
