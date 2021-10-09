using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Clone_Graph
    {
        public class Node
        {
            public int val;
            public IList<Node> neighbors;

            public Node()
            {
                val = 0;
                neighbors = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                neighbors = new List<Node>();
            }

            public Node(int _val, List<Node> _neighbors)
            {
                val = _val;
                neighbors = _neighbors;
            }
        }


        Node[] newNode = new Node[101];
        public Node CloneGraph2(Node node)
        {
            if (node == null)
                return null;

            newNode[node.val] = new Node(node.val, new List<Node>());
            Node newRoot = newNode[node.val];
            bool[] used = new bool[101];

            Traverse(node, used);

            return newRoot;
        }

        private void Traverse(Node node, bool[] used)
        {
            if (used[node.val])
                return;

            used[node.val] = true;
            foreach (var n in node.neighbors)
            {
                if(newNode[n.val] == null)
                    newNode[n.val] = new Node(n.val, new List<Node>());
                newNode[node.val].neighbors.Add(newNode[n.val]);
                Traverse(n, used);
            }
        }


        public Node CloneGraph1(Node node)
        {
            if (node == null)
                return null;

            bool[] used = new bool[101];
            //Node[] newNode = new Node[101];

            List<Node> read = new List<Node>();
            List<Node> write = new List<Node>();

            read.Add(node);
            newNode[node.val] = new Node(node.val, new List<Node>());
            Node newRoot = newNode[node.val];

            while (read.Count > 0)
            {
                foreach (Node n in read)
                {
                    foreach (Node ch in n.neighbors)
                    {
                        if (!used[ch.val])
                        {
                            write.Add(ch);
                            newNode[ch.val] = new Node(ch.val, new List<Node>());
                            used[n.val] = true;
                        }
                        if(!newNode[n.val].neighbors.Contains(newNode[ch.val]))
                            newNode[n.val].neighbors.Add(newNode[ch.val]);
                    }
                }
                read = write;
                write = new List<Node>();
            }

            return newRoot;
        }


        Node[] dest;
        bool[] used;
        public Node CloneGraph(Node node)
        {
            if (node == null)
                return null;

            dest = new Node[101];
            used = new bool[101];

            Node root = new Node(node.val, new List<Node>());

            Copy(node, root);
            return root;
        }

        private void Copy(Node node, Node root)
        {
            used[node.val] = true;
            foreach (Node child in node.neighbors)
            {
                if (dest[child.val] == null)
                    dest[child.val] = new Node(child.val, new List<Node>());
                root.neighbors.Add(dest[child.val]);

                if (!used[child.val])
                    Copy(child, dest[child.val]);
            }
        }
    }
}
