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
            this.board = new int[3, 3];
        }
        public bool CheckSquare (int row, int col)
        {
            //throw new NotImplementedException();
            return board[row, col] == 0;
            
            
        }
        public void Set (int player, int row, int col)
        {
            this.board[row, col] = player;

        }
        private bool Full()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (this.board[i, j] == 0)
                        return false;
            return true;
        }
        public BoardState Won ()
        {
            for (int i = 0; i < 3; i++)
            {
                if (this.board[i, 0] != 0 && this.board[i, 0] == this.board[i, 1] && this.board[i, 0] == this.board[i, 2])
                    return board[i, 0] == 1 ? BoardState.X_WON : BoardState.Y_WON;
                if (this.board [0,i]!=0 && this.board[0,i]==this.board[1,i] && this.board[0,i]==this.board[2,i])
                    return board[i, 0] == 1 ? BoardState.X_WON : BoardState.Y_WON;
            }
            if (this.board[0, 0] != 0 && this.board[0, 0] == this.board[1, 1] && this.board[0, 0] == this.board[2, 2])
                return board[0, 0] == 1 ? BoardState.X_WON : BoardState.Y_WON;
            if (this.board[0, 2] != 0 && this.board[0, 2] == this.board[1, 1] && this.board[0, 2] == this.board[2, 0])
                return board[0, 0] == 1 ? BoardState.X_WON : BoardState.Y_WON;
            if (Full()) return BoardState.TIE;
            return BoardState.NOT_OVER;
        }
    }
}
