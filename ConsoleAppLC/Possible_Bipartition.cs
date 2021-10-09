using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Possible_Bipartition
    {
        public bool PossibleBipartition(int n, int[][] dislikes)
        {
            HashSet<int> g1 = new HashSet<int>();
            HashSet<int> g2 = new HashSet<int>();

            bool[] used = new bool[n + 1];
            List<int>[] disL = new List<int>[n + 1];

            for (int j = 0; j < dislikes.Length; j++)
            {
                int a = dislikes[j][0];
                int b = dislikes[j][1];

                if (disL[a] == null)
                    disL[a] = new List<int>();
                if (disL[b] == null)
                    disL[b] = new List<int>();

                disL[a].Add(b);
                disL[b].Add(a);
            }

            //List<int> trav = new List<int>();
            Queue<int> trav = new Queue<int>();
            for (int i = 1; i < n + 1; i++)
            {
                if (!used[i] && disL[i] != null)
                {
                    trav.Enqueue(i);
                }

                while (trav.Count > 0)
                {
                    int k = trav.Dequeue();
                    used[k] = true;

                    HashSet<int> t1;
                    HashSet<int> t2;

                    if (g1.Contains(k) && g2.Contains(k))
                        return false;
                    else if ((!g1.Contains(k) && !g2.Contains(k)) || g1.Contains(k))
                    {
                        t1 = g1;
                        t2 = g2;
                    }
                    else //if(g2.Contains(i))
                    {
                        t1 = g2;
                        t2 = g1;
                    }
                    t1.Add(k);

                    for (int j = 0; j < disL[k].Count; j++)
                    {
                        if (disL[k][j] != k)
                        {
                            if(!used[disL[k][j]])
                                trav.Enqueue(disL[k][j]);

                            if (t1.Contains(disL[k][j]))
                                return false;
                            t2.Add(disL[k][j]);
                        }
                    }
                }
            }
            return true;
        }

        private bool Traverse(bool[] used, List<int>[] disL, int i, HashSet<int> g1, HashSet<int> g2, bool[] path)
        {
            if (path[i])
                return false;
            if (!used[i] && disL[i] != null)
            {
                HashSet<int> t1;
                HashSet<int> t2;

                if (g1.Contains(i) && g2.Contains(i))
                    return false;
                else if ((!g1.Contains(i) && !g2.Contains(i)) || g1.Contains(i))
                {
                    t1 = g1;
                    t2 = g2;
                }
                else //if(g2.Contains(i))
                {
                    t1 = g2;
                    t2 = g1;
                }

                t1.Add(i);
                path[i] = true;
                used[i] = true;
                var ret = true;
                for (int j = 0; j < disL[i].Count; j++)
                {
                    if (t2.Contains(disL[i][j]))
                        return false;
                    t2.Add(disL[i][j]);

                    if (!used[disL[i][j]] && disL[i][j] !=i)
                    {
                        t2.Add(disL[i][j]);
                        path[disL[i][j]] = true;
                        ret = ret && Traverse(used, disL, disL[i][j], g1, g2, path);
                        path[disL[i][j]] = false;
                    }
                }
                return ret;
            }
            return true;
        }
    }
}
