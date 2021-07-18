using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Group_Anagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var ret = new List<IList<string>>();
            Hashtable ht = new Hashtable();
            int[] primes = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101};

            foreach (var str in strs)
            {
                long temp = 1;
                foreach (var ch in str)
                {
                    temp = temp * primes[(int)ch - 97];
                }
                if (ht.Contains(temp))
                {
                    var lst = ht[temp] as List<string>;
                    lst.Add(str);
                }
                else
                {
                    ht.Add(temp, new List<string> { str });
                }
            }

            foreach (List<string> x in ht.Values)
            {
                ret.Add(x);
            }

            return ret;
        }
    }
}
