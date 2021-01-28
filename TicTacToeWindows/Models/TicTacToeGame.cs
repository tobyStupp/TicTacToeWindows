using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWindows.Models
{
    class TicTacToeGame
    {
        private int[,] board;
        public TicTacToeGame()
        {
            
        }
        public bool CheckSquare (int row, int col)
        {
           throw new NotImplementedException();
            
        }
        public void Set (int player, int row, int col)
        {
            

        }
        public int Won ()
        {
            //0 game not over
            // 1 X won
            // 2 O won
            // 3 Tie
            throw new NotImplementedException();
        }
    }
}
