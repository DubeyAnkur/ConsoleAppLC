using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Generate_Parentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> ret = new List<string>();

            Recurse("", 0, 0, ret, n);
            return ret;
        }

        private void Recurse(string parent, int startCount, int endCount, List<string> ret, int n)
        {
            if (startCount > endCount)
            {
                if(startCount < n)
                    Recurse(parent + "(", startCount + 1, endCount, ret, n);
                if (endCount < n)
                    Recurse(parent + ")", startCount, endCount + 1, ret, n);
            }
            else if (startCount == endCount && startCount < n)
            {
                Recurse(parent + "(", startCount+1, endCount, ret, n);
            }
            if (startCount == n && endCount == n)
            {
                ret.Add(parent);
                return;
            }
        }

    }
}
