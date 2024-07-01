using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Bot : Player
    {
        private Board board;
        public Bot(String n, Color col, Board b) : base(n,col)
        {
            board = b;
        }
    
        
    
    }
}
