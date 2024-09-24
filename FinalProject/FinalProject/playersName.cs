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
                comboBox.Size = this.Controls["textName2"].Size;
                comboBox.Items.Add("Begginer");
                comboBox.Items.Add("Hard");
                comboBox.SelectedIndex = 0;
                comboBox.BackColor = Color.FromArgb(52, 152, 219);
                comboBox.FlatStyle = FlatStyle.Flat;
                comboBox.Font = new Font("Serif", 16, FontStyle.Bold);
                comboBox.ForeColor = Color.White;
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
                else
                    name2 += "H";
            }
            Form1 form = new Form1(name1,name2);
            form.Show();
            this.Close();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
            HomeForm f = new HomeForm();
            Close();
            f.Show();
        }
    }
}
