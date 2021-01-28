using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWindows.Gui
{
   public abstract class PlayerShape
    {
        protected int topX, topY, bottomX, bottomY;
        public PlayerShape (int x1, int y1, int x2, int y2)
        {
            this.topX = x1;
            this.topY = y1;
            this.bottomX = x2;
            this.bottomY = y2;
        }
        public abstract void DrawShape(Graphics g);
    }
}
