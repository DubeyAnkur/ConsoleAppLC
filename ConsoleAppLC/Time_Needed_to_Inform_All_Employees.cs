using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Time_Needed_to_Inform_All_Employees
    {
        public class Node
        {
            public int val { get; set; }
            public int time { get; set; }
            public List<Node> child;

            public Node(int v, int t)
            {
                val = v;
                time = t;
                child = new List<Node>();
            }
        }
        Dictionary<int, Node> dic;
        int max = 0;
        public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
        {
            dic = new Dictionary<int, Node>();
            int N = manager.Length;
            Node root = null;
            for (int i = 0; i < N; i++)
            {
                Node emp = null;
                Node man = null;
                if (dic.ContainsKey(i))
                {
                    emp = dic[i];
                    emp.time = informTime[i];
                }
                else
                {
                    emp = new Node(i, informTime[i]);
                    dic.Add(i, emp);
                }

                if (dic.ContainsKey(manager[i]))
                    man = dic[manager[i]];
                else
                {
                    man = new Node(manager[i], 0);
                    dic.Add(manager[i], man);
                }
                if (manager[i] == -1)
                    root = emp;
                else
                    man.child.Add(emp);
            }
            Traverse(root, 0);
            return max;
        }

        private void Traverse(Node root, int timeYet)
        {
            if (root == null)
                return;
            max = Math.Max(timeYet, max);

            foreach (var ch in root.child)
            {
                Traverse(ch, timeYet + root.time);
            }
        }
    }
}
