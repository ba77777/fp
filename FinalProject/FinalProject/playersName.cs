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
        public playersName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name1 = textName1.Text;
            string name2 = textName2.Text;
            Form1 form = new Form1(name1,name2);
            form.Show();
            this.Close();
        }
    }
}
