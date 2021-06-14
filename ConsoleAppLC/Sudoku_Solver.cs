using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Sudoku_Solver
    {
        public void SolveSudoku(char[,] board)
        {
            bool[,] mem = new bool[9, 9];
            int i = 0, j = 0;
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    if (board[i, j] != '.')
                        mem[i, j] = true;
                }
            }

            i = 0; j = 0;
            while (i < 9 && j < 9)
            {
                if (mem[i, j] == false)
                {
                    int k = 1;
                    board[i, j] = (char)(k +48);
                    while (!Validate(board, i, j))
                    {
                        k = (int)board[i, j] - 48; // Check if its ASCII or <=9.
                        if (k < 9)
                        {
                            k++;
                            board[i, j] = (char)(k+48);
                        }
                        else
                        {
                            do
                            {
                                if(mem[i, j] == false && board[i, j] == '9')
                                    board[i, j] = '.'; 
                                j--;
                                if (j < 0)
                                {
                                    i--;
                                    j = 8;
                                }
                            }
                            while (mem[i, j] == true || board[i,j] == '9');

                            k = (int)board[i, j] - 48; // Check if its ASCII or <=9.
                            board[i, j] = (char)(k + 1 + 48);
                        }
                    }
                }
                j++;
                if (j == 9)
                { i++; j = 0; }
            }

        }

        private bool Validate(char[,] board, int i, int j)
        {
            for (int q = 0; q < 9; q++)
            {
                if (i != q && board[q, j] == board[i, j])
                    return false;
                if (j != q && board[i, q] == board[i, j])
                    return false;
            }
            int x = (i / 3) * 3;
            int y = (j / 3) * 3;

            for (int p = 0; p < 3; p++)
            {
                for (int q = 0; q < 3; q++)
                {
                    if (i != (p + x) && j != (q + y) && board[p + x, q + y] == board[i, j])
                        return false;
                }
            }

            return true;

        }


    }
}
