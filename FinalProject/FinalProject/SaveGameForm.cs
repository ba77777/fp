using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProject
{
    public partial class SaveGameForm : Form
    {
        const int FORM_LENGTH = 400;
        const int FORM_WIDTH = 600;
        public Action<int> OnSaveSlotSelected;
        private Button btnSlot1;
        private Button btnSlot2;
        private Button btnSlot3;
        public SaveGameForm()
        {
            this.Text = "Save Game";
            this.Size = new System.Drawing.Size(FORM_WIDTH, FORM_LENGTH);
            
            btnSlot1 = CreateStyledButton(1, 60);
            btnSlot2 = CreateStyledButton(2, 140);
            btnSlot3 = CreateStyledButton(3, 220);

            
            btnSlot1.Click += (sender, e) => OnSaveSlotSelected?.Invoke(1);
            btnSlot2.Click += (sender, e) => OnSaveSlotSelected?.Invoke(2);
            btnSlot3.Click += (sender, e) => OnSaveSlotSelected?.Invoke(3);

           
            this.Controls.Add(btnSlot1);
            this.Controls.Add(btnSlot2);
            this.Controls.Add(btnSlot3);
        }


        private string GetButtonText(int slot)
        {
            string filePath = $"Saves/{slot}.txt";
            if (File.Exists(filePath))
            {
                StreamReader reader = new StreamReader(filePath);
                String time = reader.ReadLine();
                String p1 = reader.ReadLine();
                String p2 = reader.ReadLine();
                reader.Close();
                p1 = (p1.Trim().Split(' ')[1]).Split('-')[1];
                p2 = (p2.Trim().Split(' ')[1]).Split('-')[1];
                return $"Save Slot {slot} {p1} VS {p2} \n{time}";
            }

            return $"Save Slot {slot}";
        }


        private Button CreateStyledButton(int slot, int top)
        {
            Button button = new Button
            {
                Text = GetButtonText(slot),
                Left = 150,
                Width = 300,
                Top = top,
                Height = 50,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Green,
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 120, 215);
            return button;
        }

        public void RefreshButtonTexts()
        {
            btnSlot1.Text = GetButtonText(1);
            btnSlot2.Text = GetButtonText(2);
            btnSlot3.Text = GetButtonText(3);
        }
    }
}
