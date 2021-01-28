using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeWindows.Models;

namespace TicTacToeWindows.Controller
{
    class TicTacToeController
    {
        private Form1 guiGame;
        private TicTacToeGame board;
  
        private int player;


        public TicTacToeController(Form1 form1)
        {
            this.guiGame = form1;
            this.board = new TicTacToeGame();
            player = new Random().Next(2) + 1;
            this.guiGame.Text = player == 1 ? "X Turn" : "O Turn";
        }
        public bool LegalMove(int row, int col)
        {
            return board.CheckSquare(row, col);
        }
        public void NextPlay()
        {
            player = (1 - (player - 1)) + 1;
            this.guiGame.Text = player == 1 ? "X Turn" : "O Turn";
        }
        public bool MakeMove(int row, int col)
        {
            if (LegalMove(row, col))
            {
                board.Set(player, row, col);
                
                guiGame.HideIllegalMove();
                
                return true;
            }
            else
            {
                guiGame.ShowIllegalMove();
                return false;
            }
        }
        public int GameOver()
        {
            return board.Won();
        }

        public bool GetXPlayer()
        {
            return player == 1;
        }
    }
}
