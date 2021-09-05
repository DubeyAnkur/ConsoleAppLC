using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Course_Schedule
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            bool[] used = new bool[numCourses];
            List<List<int>> lst = new List<List<int>>();

            bool[] path = new bool[numCourses];

            for (int i = 0; i < numCourses; i++)
                lst.Add(new List<int>());

            for (int i = 0; i < prerequisites.Length; i++)
            {
                int a = prerequisites[i][0];
                int b = prerequisites[i][1];

                lst[a].Add(b);
            }

            for (int i = 0; i < numCourses; i++)
            {
                if (!used[i])
                {
                    path = new bool[numCourses];
                    used[i] = true;
                    path[i] = true;
                    if (!Traverse(i, lst, path, used))
                        return false;
                }
            }
            return true;
        }

        private bool Traverse(int i, List<List<int>> lst, bool[] path, bool[] used)
        {
            bool ret = true;
            foreach (var j in lst[i])
            {
                if (path[j])
                    return false;
                else if (used[j])
                    continue;
                else
                {
                    path[j] = true;
                    used[j] = true;
                    ret = ret && Traverse(j, lst, path, used);
                    path[j] = false;
                }
            }
            return ret;
        }
    }
}
