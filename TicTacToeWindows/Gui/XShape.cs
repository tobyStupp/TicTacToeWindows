using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWindows.Gui
{
    public class XShape:PlayerShape
    {
        public XShape(int x, int y, int x1, int y1)
            : base(x, y, x1, y1) { }
        public override void DrawShape(Graphics g)
        {
            Pen p = new Pen(Color.Blue, 10);
            g.DrawLine(p, topX, topY, bottomX, bottomY);
            g.DrawLine(p, bottomX, topY, topX, bottomY);
        }
    }
}
