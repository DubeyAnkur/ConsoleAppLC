using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Surrounded_Regions
    {
        public void Solve(char[][] board)
        {
            int N = board.Length;
            int M = board[0].Length;

            List<Tuple<int, int>> que = new List<Tuple<int, int>>();

            for (int i = 0; i < N; i++)
            {
                if (board[i][0] == 'O')
                {
                    que.Add(new Tuple<int, int>(i, 0));
                    board[i][0] = 'Y';
                }
                if (board[i][M - 1] == 'O')
                {
                    que.Add(new Tuple<int, int>(i, M - 1));
                    board[i][M - 1] = 'Y';
                }
            }
            for (int j = 1; j < M - 1; j++)
            {
                if (board[0][j] == 'O')
                {
                    que.Add(new Tuple<int, int>(0, j));
                    board[0][j] = 'Y';
                }
                if (board[N - 1][j] == 'O')
                {
                    que.Add(new Tuple<int, int>(N - 1, j));
                    board[N - 1][j] = 'Y';
                }
            }

            for (int i = 0; i < que.Count; i++)
            {
                if (que[i].Item1 - 1 > 0 && board[que[i].Item1 - 1][que[i].Item2] == 'O')
                {
                    que.Add(new Tuple<int, int>(que[i].Item1 - 1, que[i].Item2));
                    board[que[i].Item1 - 1][que[i].Item2] = 'Y';
                }
                if (que[i].Item1 + 1 < N && board[que[i].Item1 + 1][que[i].Item2] == 'O')
                {
                    que.Add(new Tuple<int, int>(que[i].Item1 + 1, que[i].Item2));
                    board[que[i].Item1 + 1][que[i].Item2] = 'Y';
                }
                if (que[i].Item2 - 1 > 0 && board[que[i].Item1][que[i].Item2 - 1] == 'O')
                {
                    que.Add(new Tuple<int, int>(que[i].Item1, que[i].Item2 - 1));
                    board[que[i].Item1][que[i].Item2 - 1] = 'Y';
                }
                if (que[i].Item2 + 1 < M && board[que[i].Item1][que[i].Item2 + 1] == 'O')
                {
                    que.Add(new Tuple<int, int>(que[i].Item1, que[i].Item2 + 1));
                    board[que[i].Item1][que[i].Item2 + 1] = 'Y';
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (board[i][j] == 'O')
                        board[i][j] = 'X';
                    else if (board[i][j] == 'Y')
                        board[i][j] = 'O';
                }
            }


        }
    }
}
