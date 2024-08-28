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
        Boolean isCpu;
        ComboBox comboBox;
        public playersName(Boolean isCpu)
        {
            this.isCpu = isCpu;
            InitializeComponent();
            if (isCpu)
            {
                this.Controls["textName2"].Hide();
                comboBox = new ComboBox();
                comboBox.Location = this.Controls["textName2"].Location; 
                comboBox.Size = new System.Drawing.Size(150, 30);
                comboBox.Items.Add("Begginer");
                comboBox.Items.Add("Medium");
                comboBox.Items.Add("Hard");
                comboBox.SelectedIndex = 0;
                this.Controls.Add(comboBox);
                
            }
               
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name1 = textName1.Text;
            string name2 = textName2.Text;
            if (isCpu)
            {
                name2 = "CPU";
                if (comboBox.SelectedItem.ToString() == "Begginer")
                    name2 += "B";
                else if (comboBox.SelectedItem.ToString() == "Medium")
                    name2 += "M";
                else
                    name2 += "H";
            }
            Form1 form = new Form1(name1,name2);
            form.Show();
            this.Close();
        }
    }
}
