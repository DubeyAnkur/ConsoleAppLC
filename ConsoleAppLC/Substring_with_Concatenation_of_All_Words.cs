using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleAppLC
{
    class Substring_with_Concatenation_of_All_Words
    {
        //O(N * M) where N = s.Length, M = words.Length
        public IList<int> FindSubstring(string s, string[] words)
        {
            List<int> ret = new List<int>();
            Hashtable ht = new Hashtable();
            int[] count = new int[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                if (ht.ContainsKey(words[i]) == false)
                {
                    ht.Add(words[i], i);
                    count[i]++;
                }
                else
                {
                    int temp = (int)ht[words[i]];
                    count[temp]++;
                }
            }

            int N = words[0].Length;

            for (int i = 0; i < s.Length - (N * words.Length) + 1; i++)
            {
                var subStr = s.Substring(i, N);
                if (ht.ContainsKey(subStr))
                {
                    int[] tempCount = new int[count.Length];
                    count.CopyTo(tempCount, 0);
                    int k = 0;
                    for (k = 0; k < words.Length; k++)
                    {
                        subStr = s.Substring(i + (N * k), N);
                        if (ht.Contains(subStr))
                        {
                            int index = (int)ht[subStr];
                            if (tempCount[index] > 0)
                                tempCount[index]--;
                            else
                                break;
                        }
                        else
                            break;
                    }
                    if (k == words.Length)
                        ret.Add(i);
                }
            }
            return ret;

        }

        //O(N * M * M) where N = s.Length, M = words.Length
        public IList<int> FindSubstring_Slow(string s, string[] words)
        {
            List<int> ret = new List<int>();
            Hashtable ht = new Hashtable();
            int[] count = new int[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                if (ht.ContainsKey(words[i]) == false)
                {
                    ht.Add(words[i], i);
                    count[i]++;
                }
                else
                {
                    int temp = (int)ht[words[i]];
                    count[temp]++;
                }
            }

            int N = words[0].Length;

            foreach (string word in ht.Keys)
            {
                int j = s.IndexOf(word);
                while (j < s.Length && j >= 0)
                {
                    int[] tempCount = new int[count.Length];
                    count.CopyTo(tempCount, 0);

                    int k = 0;
                    for (k = 0; k < words.Length; k++)
                    {
                        if (j + (N * k) + N <= s.Length)
                        {
                            var subStr = s.Substring(j + (N * k), N);
                            if (ht.Contains(subStr))
                            {
                                int index = (int)ht[subStr];
                                if (tempCount[index] > 0)
                                    tempCount[index]--;
                                else
                                    break;
                            }
                            else
                                break;
                        }
                        else
                            break;
                    }
                    if (k == words.Length)
                        ret.Add(j);
                    j++;
                    j = s.IndexOf(word, j);
                }
            }

            return ret;
        }

    }
}
