using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWindows.Gui
{
   public class OShape:PlayerShape
    {
        public OShape(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2) { }
        public override void DrawShape(Graphics g)
        {
            Brush b = new SolidBrush(Color.Red);
            Pen p = new Pen(Color.Red, 10);
            // Brush b1 = new SolidBrush(Color.LightGray);
            g.DrawEllipse(p, topX, topY, bottomX, bottomY);
           // g.FillEllipse(b1, topX + 20, topY + 20, bottomX - 20, bottomY - 20);
        }
    }
}
