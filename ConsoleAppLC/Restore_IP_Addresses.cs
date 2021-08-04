using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Restore_IP_Addresses
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            var ret = new List<string>();
            if (s.Length > 12 || s.Length < 4)
                return ret;

            BuildTree(ret, new List<int>(), s, 0, 0);
            BuildTree(ret, new List<int>(), s, 0, 1);
            BuildTree(ret, new List<int>(), s, 0, 2);

            return ret;
        }

        private bool BuildTree(List<string> ret, List<int> current, string s, int start, int end)
        {
            if (end >= s.Length) return false;
            if (current.Count == 4 && end != s.Length - 1) return false;
            if (s.Length - start > (4 - current.Count) * 3) return false;

            var str = s.Substring(start, end - start+1);
            if (str.StartsWith('0') && str.Length > 1) return false;

            var num = Convert.ToInt32(str);
            if (num < 256)
            {
                current.Add(num);
                if (current.Count == 4 && end == s.Length - 1)
                {
                    ret.Add(current[0] + "." + current[1] + "." + current[2] + "." + current[3]);
                    return true;
                }
            }
            else return false;

            if(BuildTree(ret, current, s, end + 1, end + 1))
                current.RemoveAt(current.Count - 1);

            if(BuildTree(ret, current, s, end + 1, end + 2))
                current.RemoveAt(current.Count - 1);
            
            if(BuildTree(ret, current, s, end + 1, end + 3))
                current.RemoveAt(current.Count - 1);

            return true;
        }
    }
}
