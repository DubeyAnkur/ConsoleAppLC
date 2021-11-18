using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Remove_Invalid_Parentheses
    {

        public class ParVal
        {
            public string Val { get; set; }
            public int Count { get; set; }

            public ParVal(string v, int c)
            {
                Val = v;
                Count = c;
            }
        }
        public IList<string> RemoveInvalidParentheses(string s)
        {
            var ret = new List<string>();
            Dictionary<string, ParVal> hsRead = new Dictionary<string, ParVal>();
            Dictionary<string, ParVal> hsWrite = new Dictionary<string, ParVal>();

            hsRead.Add("", new ParVal("", 0));
            for (int i = 0; i < s.Length; i++)
            {
                foreach (var key in hsRead)
                {
                    ParVal pv = key.Value;
                    if (s[i] == ')')
                    {
                        if (pv.Count > 0)
                        {
                            if(!hsWrite.ContainsKey(pv.Val + s[i])) hsWrite.Add(pv.Val + s[i], new ParVal(pv.Val + s[i], pv.Count - 1));
                            if (!hsWrite.ContainsKey(pv.Val)) hsWrite.Add(pv.Val, pv);
                        }
                        else
                            hsWrite.Add(pv.Val, pv);
                    }
                    else if (s[i] == '(')
                    {
                        if (!hsWrite.ContainsKey(pv.Val + s[i])) hsWrite.Add(pv.Val + s[i], new ParVal(pv.Val + s[i], pv.Count + 1));
                        if (!hsWrite.ContainsKey(pv.Val)) hsWrite.Add(pv.Val, new ParVal(pv.Val, pv.Count));
                    }
                    else
                    {
                        if (!hsWrite.ContainsKey(pv.Val + s[i])) hsWrite.Add(pv.Val + s[i], new ParVal(pv.Val + s[i], pv.Count));
                    }
                }
                hsRead = hsWrite;
                hsWrite = new Dictionary<string, ParVal>();
            }

            int maxCount = 0;
            List<string> temp = new List<string>();
            foreach (var key in hsRead)
            {
                ParVal pv = key.Value;
                if (pv.Count == 0 && pv.Val.Length >= maxCount)
                {
                    temp.Add(pv.Val);
                    maxCount = Math.Max(maxCount, pv.Val.Length);
                }
            }

            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].Length == maxCount)
                    ret.Add(temp[i]);
            }

            return ret;
        }
    }
}
