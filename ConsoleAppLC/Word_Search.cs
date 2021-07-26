using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Word_Search
    {
        public bool Exist1(char[][] board, string word)
        {
            if (word.Length > board.Length * board[0].Length)
                return false;

            bool[,] used = new bool[board.Length, board[0].Length];
            for (int a = 0; a < board.Length; a++)
                for (int b = 0; b < board[0].Length; b++)
                {
                    if (word[0] == board[a][b])
                    {
                        if (backtrack(board, word, used, a, b, 0))
                            return true;
                    }
                }
            return false;
        }

        private bool backtrack1(char[][] board, string word, bool[,] used, int i, int j, int k)
        {
            if (k == word.Length) return true;

            if (i < 0 || j < 0 || i == board.Length || j == board[0].Length) return false;
            if (board[i][j] != word[k] || used[i, j]) return false;


            used[i, j] = true;

            bool there = backtrack(board, word, used, i - 1, j, k + 1) || backtrack(board, word, used, i + 1, j, k + 1) || backtrack(board, word, used, i, j - 1, k + 1) || backtrack(board, word, used, i, j + 1, k + 1);

            used[i, j] = false;

            return there;

        }

        public bool Exist(char[][] board, string word)
        {
            if (word.Length > board.Length * board[0].Length)
                return false;

            bool[,] used = new bool[board.Length, board[0].Length];
            for (int a = 0; a < board.Length; a++)
                for (int b = 0; b < board[0].Length; b++)
                {
                    if (word[0] == board[a][b])
                    {
                        used[a, b] = true;
                        if (backtrack(board, word, used, a, b, 1))
                            return true;
                        used[a, b] = false;
                    }
                }
            return false;
        }

        private bool backtrack(char[][] board, string word, bool[,] used, int i, int j, int k)
        {
            if (k == word.Length)
                return true;
            if (i > 0 && board[i - 1][j] == word[k] && !used[i - 1, j])
            {
                used[i - 1, j] = true;
                if (backtrack(board, word, used, i - 1, j, k + 1))
                    return true;
                used[i - 1, j] = false;
            }
            if (i < board.Length - 1 && board[i + 1][j] == word[k] && !used[i + 1, j])
            {
                used[i + 1, j] = true;
                if (backtrack(board, word, used, i + 1, j, k + 1))
                    return true;
                used[i + 1, j] = false;
            }
            if (j > 0 && board[i][j - 1] == word[k] && !used[i, j - 1])
            {
                used[i, j - 1] = true;
                if (backtrack(board, word, used, i, j - 1, k + 1))
                    return true;
                used[i, j - 1] = false;
            }
            if (j < board[0].Length - 1 && board[i][j + 1] == word[k] && !used[i, j + 1])
            {
                used[i, j + 1] = true;
                if (backtrack(board, word, used, i, j + 1, k + 1))
                    return true;
                used[i, j + 1] = false;
            }
            return false;
        }

    }
}
