using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Player
    {
        private String name = "";
        private Color col;
        public Player(String n,Color col)
        {
            name = n;
            this.col = col;
        }

        public String getName()
        {
            return name;
        }

        public Color getColor()
        {
            return col;
        }
    }
}
