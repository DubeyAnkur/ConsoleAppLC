using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{

    public class AVLNode
    {
        public int val { get; set; }
        public int lHeight { get; set; }

        public int rHeight { get; set; }
        public AVLNode right { get; set; }
        public AVLNode left { get; set; }

        public AVLNode(int newVal)
        {
            val = newVal;
        }
    }

    class AVLTree
    {
        AVLNode root = null;
        public void CreateTree()
        {
            //root = new AVLNode();
        }

        public void InsertNode(int newVal)
        {
            root = InsertNode(root, newVal);
        }

        private AVLNode InsertNode(AVLNode root, int newVal)
        {
            if (root == null)
                root = new AVLNode(newVal);
            else if (root.val < newVal)
            {
                root.right = InsertNode(root.right, newVal);
                root.rHeight = Math.Max(root.right.lHeight, root.right.rHeight) + 1;
            }
            else if (root.val > newVal)
            {
                root.left = InsertNode(root.left, newVal);
                root.lHeight = Math.Max(root.left.lHeight, root.left.rHeight) + 1;
            }

            int bf = root.lHeight - root.rHeight;

            if (bf < -1 && newVal > root.right.val) // RR
                root = RotateLeft(root);
            else if (bf < -1 && newVal < root.right.val) //LR
            {
                root.left = RotateRight(root.right);
                root = RotateLeft(root);
            }
            else if (bf > 1 && newVal > root.right.val) //RL
            {
                root.right = RotateLeft(root.right);
                root = RotateRight(root);
            }
            else if (bf > 1 && newVal < root.right.val) //LL
                root = RotateRight(root);

            return root;
        }
        private AVLNode RotateRight(AVLNode gp)
        {
            var p = gp.left;
            var pr = p.right;
            p.right = gp;
            gp.left = pr;

            gp.lHeight = gp.left == null ? 0 : Math.Max(gp.left.lHeight, gp.left.rHeight) + 1;
            p.rHeight = p.right == null ? 0 : Math.Max(p.right.lHeight, p.right.rHeight) + 1;

            return p;
        }

        private AVLNode RotateLeft(AVLNode gp)
        {
            var p = gp.right;
            var pl = p.left;
            p.left = gp;
            gp.right = pl;

            gp.rHeight = gp.right == null ? 0 : Math.Max(gp.right.lHeight, gp.right.rHeight) + 1;
            p.lHeight = p.left == null ? 0 : Math.Max(p.left.lHeight, p.left.rHeight) + 1;

            return p;
        }

        public void DeleteNode(int delVal)
        {
            DeleteNode(root, delVal);
        }

        private AVLNode DeleteNode(AVLNode root, int delVal)
        {
            if (root == null)
            {
                //Item not round
                return null;
            }
            else if (root.val < delVal)
            {
                root.right = DeleteNode(root.right, delVal);
                root.rHeight = Math.Max(root.right.lHeight, root.right.rHeight) + 1;
            }
            else if (root.val > delVal)
            {
                root.left = DeleteNode(root.left, delVal);
                root.lHeight = Math.Max(root.left.lHeight, root.left.rHeight) + 1;
            }
            else //root.val == delVal
            {
                if (root.left == null)
                    return root.right;
                else if (root.right == null)
                    return root.left;
                else
                {
                    var temp = getPrevVal(root.left);
                    root.val = temp.val;
                    root.left = DeleteNode(root.left, temp.val);
                }
            }

            int bf = root.lHeight - root.rHeight;

            if (bf < -1 && delVal < root.left.val) // LL
                root = RotateRight(root);
            else if (bf < -1 && delVal > root.left.val) //LR
            {
                root.left = RotateRight(root.left);
                root = RotateLeft(root);
            }
            else if (bf > 1 && delVal < root.right.val) //RL
            {
                root.right = RotateLeft(root.right);
                root = RotateRight(root);
            }
            else if (bf > 1 && delVal < root.right.val) //RR
                root = RotateLeft(root);

            return root;
        }

        private AVLNode getPrevVal(AVLNode root)
        {
            while (root.right != null)
                root = root.right;
            return root;
        }

        public void Print()
        {

        }

    }
}
