using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Word_Search_II
    {
        public class Trie
        {
            public char ch;
            public bool end;
            public Trie[] Child;
            public Trie parent;

            public Trie(char c, Trie p)
            {
                ch = c;
                Child = new Trie[26];
                parent = p;
            }
        }
        HashSet<string> hs = new HashSet<string>();
        public IList<string> FindWords(char[][] board, string[] words)
        {
            Trie root = new Trie(' ', null);

            foreach (var w in words)
            {
                Trie n = root;
                for (int i = 0; i < w.Length; i++)
                {
                    int index = w[i] - 'a';
                    if (n.Child[index] == null)
                        n.Child[index] = new Trie(w[i], n);
                    n = n.Child[index];
                }
                n.end = true;
            }

            int N = board.Length;
            int M = board[0].Length;
            bool[,] trav = new bool[N, M];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    trav = new bool[N, M];
                    Traverse(board, trav, i, j, N, M, root, "");
                }

            var ret = new string[hs.Count];
            int count = 0;
            foreach (var s in hs)
            {
                ret[count] = s;
                count++;
            }
            return ret;
        }

        private void Traverse(char[][] board, bool[,] trav, int i, int j, int N, int M, Trie root, string word)
        {
            if (root == null)
                return;
            if (root.end)
            {
                hs.Add(word);
                int childCount = 0;
                for (int x = 0; x < 26; x++)
                {
                    if (root.Child[x] != null)
                        childCount++;
                }
                if (childCount == 0)
                    root.parent.Child[root.ch - 'a'] = null;
            }
            if (i < 0 || j < 0 || i >= N || j >= M || trav[i, j]) return;

            int index = board[i][j] - 'a';
            if (root.Child[index] != null)
            {
                trav[i, j] = true;
                Traverse(board, trav, i + 1, j, N, M, root.Child[index], word + board[i][j]);
                Traverse(board, trav, i - 1, j, N, M, root.Child[index], word + board[i][j]);
                Traverse(board, trav, i, j + 1, N, M, root.Child[index], word + board[i][j]);
                Traverse(board, trav, i, j - 1, N, M, root.Child[index], word + board[i][j]);
                trav[i, j] = false;
            }
        }
    }
}
