using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    public class LFUCache
    {
        private class Node
        {
            public int Key { get; set; }
            public int Value { get; set; }
            public int Count { get; set; }

            public Node Prev { get; set; }
            public Node Next { get; set; }

            public Node Up { get; set; }
            public Node Down { get; set; }

            public Node(int k, int v, int c)
            {
                Key = k;
                Value = v;
                Count = c;
            }
        }

        //int OverAllCount = 0;
        Node GStart;
        Node GEnd;
        int cap;
        Hashtable ht;
        Hashtable htCount;
        public LFUCache(int capacity)
        {
            cap = capacity;
            GStart = new Node(0, 0, 0);
            GEnd = new Node(0, 0, 0);

            GStart.Next = GEnd;
            GEnd.Prev = GStart;

            ht = new Hashtable();
            htCount = new Hashtable();
        }

        private void update(int key, int value)
        {
            //Increase Count
            Node del = (Node)ht[key];
            Node prev = null;
            if (htCount.Contains(del.Count))
                prev = (Node)htCount[del.Count];

            //Delete List
            if (del.Up == del.Down)
                prev = deleteList(del);
            else
            {
                //Delete Node
                del.Up.Down = del.Down;
                del.Down.Up = del.Up;
            }

            Node n = (Node)ht[key];
            n.Value = value;
            n.Count++;

            Node nuS;
            //Insert List
            if (htCount.Contains(n.Count))
                nuS = (Node)htCount[n.Count];
            else
                nuS = insertList(prev, n.Count);
            //Insert Node
            insertNode(nuS, n);
        }

        private void insertNode(Node nuS, Node n)
        {
            Node end = nuS;
            end.Up.Down = n;
            n.Up = end.Up;
            end.Up = n;
            n.Down = end;
        }

        private Node insertList(Node prev, int count)
        {
            Node nuS = new Node(0, 0, count);
            nuS.Down = nuS;
            nuS.Up = nuS;

            prev.Next.Prev = nuS;
            nuS.Next = prev.Next;
            prev.Next = nuS;
            nuS.Prev = prev;

            htCount.Add(count, nuS);
            return nuS;
        }

        private Node deleteList(Node del)
        {
            //Delete List
            Node prev = del.Up.Prev;
            del = del.Up;
            del.Prev.Next = del.Next;
            del.Next.Prev = del.Prev;

            htCount.Remove(del.Count);
            return prev;
        }

        public int Get(int key)
        {
            if (ht.Contains(key))
            {
                Node n = (Node)ht[key];
                update(key, n.Value);

                return n.Value;
            }
            else
                return -1;
        }
        public void Put(int key, int value)
        {
            if (cap == 0)
                return;
            if (ht.Contains(key))
            {
                update(key, value);
            }
            else
            {
                Node n = new Node(key, value, 1);
                ht.Add(key, n);

                if (ht.Count > cap)
                {
                    //Delete Node
                    Node del = GStart.Next.Down;
                    del.Up.Down = del.Down;
                    del.Down.Up = del.Up;

                    //Delete List
                    if (GStart.Next.Down == GStart.Next)
                        deleteList(GStart.Next);

                    //Remove Node from ht
                    ht.Remove(del.Key);
                }


                //Insert List
                if (GStart.Next.Count != 1)
                {
                    insertList(GStart, 1);
                }
                //Insert Node
                insertNode(GStart.Next, n);
            }
        }
    }
}
