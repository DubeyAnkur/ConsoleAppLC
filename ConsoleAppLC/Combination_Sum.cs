using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Combination_Sum
    {
        class TreeNode
        {
            public int Value;
            public int Index;
            public int Total;
            public List<TreeNode> Child = new List<TreeNode>();
            public List<int> path = new List<int>();
        }

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> ret = new List<IList<int>>();
            var root = new TreeNode();

            Array.Sort(candidates);
            foreach (var i in candidates)
            {
                var x = new TreeNode()
                {
                    Value = i,
                    Index = 1,
                    Total = i,
                    Child = new List<TreeNode>(),
                };
                x.path.Add(i);
                root.Child.Add(x);
            }

            Traverse(root, target, candidates, ret);

            return ret;
        }

        private void Traverse(TreeNode current, int target, int[] candidates, IList<IList<int>> ret)
        {
            if (current.Total == target)
            {
                ret.Add(current.path);
                return;
            }
            else if (current.Total > target)
                return;

            //Traverse & Add Child Nodes.
            foreach (var ch in current.Child)
            {
                foreach (var i in candidates)
                {
                    if (i >= ch.Value)
                    {
                        var x = new TreeNode()
                        {
                            Value = i,
                            Index = ch.Index + 1,
                            Total = ch.Total + i,
                            Child = new List<TreeNode>()
                        };

                        x.path.AddRange(ch.path);
                        x.path.Add(i);

                        ch.Child.Add(x);
                    }
                }
                Traverse(ch, target, candidates, ret);

            }
        }



    }
}
