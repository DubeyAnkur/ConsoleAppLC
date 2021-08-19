using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Word_Ladder_II
    {
        public IList<IList<string>> FindLadders1(string beginWord, string endWord, IList<string> wordList)
        {
            List<IList<string>> ret = new List<IList<string>>();
            bool[] used = new bool[wordList.Count];

            if (!wordList.Contains(endWord))
                return ret;

            Traverse(beginWord, endWord, wordList, used, ret, new List<string>());

            int minLength = int.MaxValue;
            foreach (var r in ret)
            {
                minLength = Math.Min(minLength, r.Count);
            }

            var newRet = new List<IList<string>>();
            foreach (var r in ret)
            {
                if (r.Count == minLength)
                {
                    r.Insert(0, beginWord);
                    newRet.Add(r);
                }
            }

            return newRet;
        }

        private void Traverse(string beginWord, string endWord, IList<string> wordList, bool[] used, List<IList<string>> ret, List<string> path)
        {
            if (beginWord == endWord)
            {
                ret.Add(new List<string>(path));
            }

            for (int i = 0; i < wordList.Count; i++)
            {
                if (!used[i] && wordDiff(beginWord, wordList[i]) == 1)
                {
                    path.Add(wordList[i]);
                    used[i] = true;

                    Traverse(wordList[i], endWord, wordList, used, ret, path);

                    path.RemoveAt(path.Count - 1);
                    used[i] = false;
                }
            }
        }

        private int wordDiff(string a, string b)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) count++;
            }
            return count;
        }

        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            var ret = new List<IList<string>>();

            List<List<string>> read = new List<List<string>>();
            List<List<string>> write = new List<List<string>>();

            read.Add(new List<string>());
            read[0].Add(beginWord);

            while (read.Count > 0)
            {
                var remove = new List<string>();
                for (int i = 0; i < read.Count; i++)
                {
                    for (int j = wordList.Count-1; j >= 0; j--)
                    {
                        if (wordDiff(read[i][read[i].Count - 1], wordList[j]) == 1)
                        {
                            var tempList = new List<string>(read[i]);
                            var thisWord = wordList[j];
                            tempList.Add(thisWord);
                            write.Add(tempList);
                            
                            if (thisWord == endWord)
                                ret.Add(write[write.Count - 1]);
                            else
                                remove.Add(wordList[j]);
                        }
                    }
                }
                foreach (var w in remove)
                    wordList.Remove(w);

                if (ret.Count > 0)
                    return ret;
                read = write;
                write = new List<List<string>>();
            }
            return ret;
        }


    }
}
