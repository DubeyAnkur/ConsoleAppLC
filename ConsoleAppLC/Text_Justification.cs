using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Text_Justification
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            var ret = new List<string>();

            int len = -1;
            int start = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (len + words[i].Length + 1 > maxWidth)
                {
                    ret.Add(GetLine(words, maxWidth, len, start, i));
                    len = -1;
                    start = i;
                }
                len = len + words[i].Length + 1;
            }

            //Last Line
            var l = "";
            for (int i = start; i < words.Length; i++)
            {
                if(i != start)
                    l = l + " ";
                l = l + words[i];
            }
            l = l + new string(' ', maxWidth - l.Length);
            ret.Add(l);

            return ret;
        }

        private string GetLine(string[] words, int maxWidth, int len, int start, int i)
        {
            int extra = maxWidth - len;
            int q = i - start - 1 > 0 ? extra / (i - start - 1) : extra - 1;
            int r = i - start - 1 > 0 ? extra % (i - start - 1) : 0;
            string l = "";

            for (int j = start; j < i; j++)
            {
                var space = new string(' ', q + 1) + (j - start < r ? " " : "");
                if (j == i - 1 && i - start - 1 > 0)
                    space = "";
                l = l + words[j] + space;
            }
            return l;
        }
    }
}
