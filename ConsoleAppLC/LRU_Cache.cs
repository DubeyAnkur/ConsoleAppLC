using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    public class LRUCache
    {
        private class Node
        {
            public int val { get; set; }
            public int key { get; set; }
            public Node prev { get; set; }
            public Node next { get; set; }

            public Node(int _key)
            {
                key = _key;
            }
        }
        Node start;
        Node end;
        //Hashtable ht = new Hashtable();
        Dictionary<int, Node> dt = new Dictionary<int, Node>();
        int GCap = 0;
        public LRUCache(int capacity)
        {
            GCap = capacity;
            start = new Node(int.MinValue);
            end = new Node(int.MaxValue);
            start.next = end;
            end.prev = start;

        }
        public int Get(int key)
        {
            if (dt.ContainsKey(key))
            {
                Node n = (Node)dt[key];

                n.prev.next = n.next;
                n.next.prev = n.prev;

                end.prev.next = n;
                n.next = end;
                n.prev = end.prev;
                end.prev = n;

                return n.val;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (dt.ContainsKey(key))
            {
                Node n = dt[key];
                n.val = value;

                n.prev.next = n.next;
                n.next.prev = n.prev;

                end.prev.next = n;
                n.next = end;
                n.prev = end.prev;
                end.prev = n;
            }
            else
            {
                Node n = new Node(key);
                n.val = value;

                n.prev = end.prev;
                end.prev.next = n;
                n.next = end;
                end.prev = n;

                dt.Add(key, n);
                if(dt.Count > GCap)
                {
                    dt.Remove(start.next.key);
                    start.next = start.next.next;
                    start.next.prev = start;

                }
            }

        }
    }




    public class LRUCache_Old
    {

        private class Node
        {
            public int val { get; set; }
            public int key { get; set; }
            public Node prev { get; set; }
            public Node next { get; set; }
        }
        Node start;
        Node end;
        Hashtable ht = new Hashtable();
        int GCap = 0;
        public LRUCache_Old(int capacity)
        {
            GCap = capacity;
        }

        public int Get(int key)
        {
            if (ht.Contains(key))
            {
                Node n = (Node)ht[key];
                if (n == start && n.next != null)
                {
                    start = n.next;
                }
                if (n != end)
                {
                    if (n.prev != null)
                        n.prev.next = n.next;
                    if (n.next != null)
                        n.next.prev = n.prev;

                    if (end != null) end.next = n;
                    n.prev = end;
                    end = end.next;
                    n.next = null;
                }

                return n.val;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (ht.Contains(key))
            {
                Node n = (Node)ht[key];
                n.val = value;
                if (n == start && n.next != null)
                {
                    start = n.next;
                }
                if (n != end)
                {
                    if (n.prev != null)
                        n.prev.next = n.next;
                    if (n.next != null)
                        n.next.prev = n.prev;

                    if (end != null) end.next = n;
                    n.prev = end;
                    end = end.next;
                    n.next = null;
                }
            }
            else
            {
                Node n = new Node();
                n.key = key;
                n.val = value;
                n.prev = end;
                if (end != null)
                    end.next = n;
                else
                    end = n;

                if (end.next != null) end = end.next;
                if (start == null) start = n;

                ht.Add(key, n);

                if (ht.Count > GCap)
                {
                    ht.Remove(start.key);
                    start = start.next;
                    start.prev = null;
                }
            }

        }
    }

    /**
     * Your LRUCache object will be instantiated and called as such:
     * LRUCache obj = new LRUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */
}
