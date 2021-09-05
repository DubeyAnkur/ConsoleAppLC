using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppLC
{
    class Accounts_Merge
    {
        public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            int N = accounts.Count;
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            Dictionary<string, string> dicName = new Dictionary<string, string>();

            for (int i = 0; i < N; i++)
            {
                for (int j = 1; j < accounts[i].Count; j++)
                {
                    string email = accounts[i][j];
                    if (dic.ContainsKey(email))
                    {
                        dic[email].AddRange(accounts[i].Skip(1));
                    }
                    else
                    {
                        dicName.Add(email, accounts[i][0]);
                        dic.Add(email, new List<string>(accounts[i].Skip(1)));
                    }
                }
            }

            var ret = new List<IList<string>>();
            HashSet<string> traversed = new HashSet<string>();

            foreach (var k in dic.Keys)
            {
                if (!traversed.Contains(k))
                {
                    HashSet<string> hs = new HashSet<string>();

                    Traverse(dic, k, hs, traversed);

                    var temp = new List<string>();
                    foreach (var email in hs)
                    {
                        temp.Add(email);
                    }
                    temp.Sort((Comparison<String>)((String left, String right) => {return String.CompareOrdinal(left, right);} ));
                    temp.Insert(0, dicName[k]);
                    ret.Add(temp);
                }
            }
            return ret;
        }

        private void Traverse(Dictionary<string, List<string>> dic, string email, HashSet<string> hs, HashSet<string> traversed)
        {
            if (hs.Contains(email)) return;
            hs.Add(email);
            traversed.Add(email);

            for (int i = 0; i < dic[email].Count; i++)
            {
                Traverse(dic, dic[email][i], hs, traversed);
            }
        }

    }
}
