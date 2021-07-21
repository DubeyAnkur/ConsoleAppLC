using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Simplify_Path
    {
        public string SimplifyPath(string path)
        {
            string ret = "";
            Stack<string> st = new Stack<string>();
            foreach (var p in path.Split('/'))
            {
                if (p == ".." && st.Count > 0)
                    st.Pop();
                else if (!(p == ".." || p == "." || p == ""))
                    st.Push(p);
            }

            while (st.Count > 0)
                ret = "/" + st.Pop() + ret;

            return ret == ""? "/": ret;
        }
    }
}
