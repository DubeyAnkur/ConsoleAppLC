using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Course_Schedule_II
    {
        private class Node
        {
            public int Value { get; set; }
            public List<Node> ch { get; set; }
            public Node(int val)
            {
                Value = val;
                ch = new List<Node>();
            }
        }

        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            Node[] all = new Node[numCourses];
            bool[] child = new bool[numCourses];

            List<int> ret = new List<int>();

            for (int i = 0; i < prerequisites.Length; i++)
            {
                int a = prerequisites[i][0];
                int b = prerequisites[i][1];

                if (all[a] == null)
                    all[a] = new Node(a);
                if (all[b] == null)
                    all[b] = new Node(b);

                all[a].ch.Add(all[b]);
                child[b] = true;
            }

            bool[] trav = new bool[numCourses];

            for (int i = 0; i < numCourses; i++)
            {
                if (all[i] == null)
                    ret.Add(i);
                else if (child[i] == false)
                {
                    bool[] path = new bool[numCourses];
                    path[i] = true;
                    if (!POT(all[i], ret, trav, path))
                        return new int[0];
                }
            }
            return ret.ToArray();
        }

        private bool POT(Node n, List<int> ret, bool[] trav, bool[] path)
        {
            bool noLoop = true;
            foreach (var c in n.ch)
            {
                if (path[c.Value])
                    return false;
                if (!trav[c.Value])
                {
                    path[c.Value] = true;
                    trav[c.Value] = true;
                    noLoop = noLoop && POT(c, ret, trav, path);
                    path[c.Value] = false;
                }
            }
            ret.Add(n.Value);
            return noLoop;
        }

    }
}
