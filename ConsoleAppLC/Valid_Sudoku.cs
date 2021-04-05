using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Valid_Sudoku
    {
        public bool IsValidSudoku(char[,] board)
        {
            bool ret = true;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i,j] != '.')
                    {
                        for (int k = 0; k < 9; k++)
                        {
                            if (i != k && board[k,j] == board[i,j])
                                return false;
                            if (j != k && board[i,k] == board[i,j])
                                return false;
                        }
                        int x = (i / 3) * 3;
                        int y = (j / 3) * 3;

                        for (int p = 0; p < 3; p++)
                        {
                            for (int q = 0; q < 3; q++)
                            {
                                if (i != (p+x) && j != (q+y) && board[p+x,q+y] == board[i,j])
                                    return false;
                            }
                        }

                    }
                }
            }

            return ret;
        }
    }
}
