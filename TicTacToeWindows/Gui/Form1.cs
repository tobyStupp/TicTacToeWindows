using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeWindows.Controller;
using TicTacToeWindows.Gui;

namespace TicTacToeWindows
{
    public partial class Form1 : Form
    {
        private int[] x = { 100, 250, 410, 570 };
        private int[] y = {20,140,280,420 };
        private List<PlayerShape> p;

        private TicTacToeController controller;
       
        public Form1()
        {
            p = new List<PlayerShape>();
            InitializeComponent();
            controller = new TicTacToeController(this);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush b = new SolidBrush(Color.Black);
           for (int i = 0; i < 2; i++)
                g.FillRectangle(b, 100, (i+1)*140,470, 10);
            // for (int i = 0; i < 2; i++)
            g.FillRectangle(b, 250, 20, 10, 400);
            g.FillRectangle(b, 410, 20, 10, 400);
            foreach (PlayerShape s in p)
                s.DrawShape(g);
          
        }

        internal void HideIllegalMove()
        {
            label1.Visible = false;
        }

        public void ShowIllegalMove()
        {
            label1.Visible = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button== MouseButtons.Left)
            { 
            bool inRangeX = e.X >= x[0] && e.X <= x[3];
            bool inRangeY = e.Y >= y[0] && e.Y <= y[3];
                if (inRangeX && inRangeY)
                {
                    int i = 0;
                    while (x[i] < e.X)
                        i++;
                    int j = 0;
                    while (y[j] < e.Y)
                        j++;
                    if (controller.MakeMove(i-1, j-1))
                    {
                        if (controller.GetXPlayer())
                            p.Add(new XShape(x[i - 1] + 10, y[j - 1] + 10, x[i] - 10, y[j] - 10));
                        else
                            p.Add(new OShape(x[i - 1] + 40, y[j - 1] + 20, 80, 90));
                        controller.NextPlay();
                        Refresh();
                        int winner = controller.GameOver();
                          
                            if (winner!=0)
                        {
                            this.Enabled = false;
                            this.Text = winner == 1 ? "X WON!" : winner == 2 ? "O WON" : "TIE";
                        }

                        }
                       
                    }
                }
            }
           
               
                
        }
    }
}
