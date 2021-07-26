using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Minimum_Window_Substring
    {

        public string MinWindow(string s, string t)
        {
            string ret = "";
            if (s.Length == 0 || t.Length == 0 || t.Length > s.Length)
                return "";
            //Hashtable search = new Hashtable();
            int[] search = new int[128];
            foreach (var c in t)
                search[c]++;

            int l = 0, r = 0;
            int letterCount = 0;
            int minLength = int.MaxValue;
            //Hashtable window = new Hashtable();
            int[] window = new int[128];
            while (r < s.Length)
            {
                if (search[s[r]] > 0)
                {
                    window[s[r]]++;

                    if (search[s[r]] >= window[s[r]])
                        letterCount++;

                    while (letterCount == t.Length)
                    {
                        if (minLength > r - l + 1)
                        {
                            minLength = r - l + 1;
                            ret = s.Substring(l, minLength);
                        }

                        if (window[s[l]] > 0)
                        {
                            window[s[l]]--;

                            if (search[s[l]] > window[s[l]])
                                letterCount--;
                        }
                        l++;
                    }
                }
                r++;
            }
            return ret;
        }

        public string MinWindow_1(string s, string t)
        {
            if (s.Length == 0 || t.Length == 0 || t.Length > s.Length)
                return "";
            Hashtable search = new Hashtable();
            Hashtable window = new Hashtable();
            foreach (var c in t)
            {
                if (search.Contains(c))
                {
                    int x = (int)search[c];
                    search[c] = ++x;
                }
                else
                    search.Add(c, 1);
            }

            var line = new List<Tuple<char, int>>();

            for (int i = 0; i < s.Length; i++)
            {
                if (search.Contains(s[i]))
                {
                    line.Add(new Tuple<char, int>(s[i], i));
                }
            }

            int l = 0, r = 0;
            int letterCount = 0;
            int minWindow = int.MaxValue;
            var ret = "";
            while (r < line.Count)
            {
                if (window.Contains(line[r].Item1))
                {
                    int x = (int)window[line[r].Item1];
                    window[line[r].Item1] = ++x;
                }
                else
                    window.Add(line[r].Item1, 1);

                if ((int)search[line[r].Item1] >= (int)window[line[r].Item1])
                    letterCount++;

                while (t.Length == letterCount)
                {
                    if (minWindow > line[r].Item2 - line[l].Item2 + 1)
                    {
                        minWindow = line[r].Item2 - line[l].Item2 + 1;
                        ret = s.Substring(line[l].Item2, minWindow);
                    }
                    int x = (int)window[line[l].Item1];
                    window[line[l].Item1] = --x;

                    if ((int)search[line[l].Item1] > (int)window[line[l].Item1])
                        letterCount--;

                    l++;
                }

                r++;
            }
            return ret;
        }
    }
}
