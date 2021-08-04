using System;
using static ConsoleAppLC.Remove_Nth_Node_From_End_of_List;

namespace ConsoleAppLC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Recover_Binary_Search_Tree tr = new Recover_Binary_Search_Tree();
            var l = new TreeNode(3, null, null);
            var r = new TreeNode(1, null, null);
            var root = new TreeNode(2, l, r);
            tr.RecoverTree(root);

            //Reverse_Linked_List_II rl = new Reverse_Linked_List_II();
            //var b = new ListNode(6, null);
            //var b = new ListNode(6, null);
            //var a = new ListNode(5, b);
            //var z = new ListNode(4, a);
            //var y = new ListNode(3, z);
            //var x = new ListNode(2, y);
            //ListNode head = new ListNode(1, x);
            //rl.ReverseBetween(head, 1,6);

            //Set_Matrix_Zeroes sm = new Set_Matrix_Zeroes();
            //int[][] mat = new int[3][] {
            //    new int[] { 0,1,2,0},
            //    new int[] { 3,4,5,2},
            //    new int[] { 1,3,1,5}
            //};
            //sm.SetZeroes(mat);


            //Minimum_Path_Sum mp = new Minimum_Path_Sum();
            //int[][] m = new int[][] { 
            //    new int[] { 1,3,1},
            //    new int[] { 1, 5, 1},
            //    new int[] { 4, 2, 1}
            //};
            //Console.WriteLine(mp.MinPathSum(m));

            //int[][] a = new int[][] {
            //    new int[] {2, 5 },
            //    new int[] {6, 7 },
            //    new int[] {8, 9 }
            //};
            //Insert_Interval ii = new Insert_Interval();
            //ii.Insert(a, new int[] { 0,1});


            //int[][] matrix = { { 1,2,3},{ 4,5,6},{ 7,8,9} };
            //Rotate_Image ri = new Rotate_Image();
            //ri.Rotate(matrix);


            //char[,] su =  { { '.', '.', '4', '.', '.', '.', '.', '7', '.'},
            //    { '5', '.', '.', '.', '.', '6', '.', '.', '.'},
            //    {'.', '.', '.', '5', '.', '.', '.', '.', '3'},
            //    {'.', '3', '.', '.', '.', '.', '7', '.', '.'},
            //    {'.', '.', '.', '.', '6', '.', '.', '.', '.'},
            //    {'.', '.', '1', '.', '.', '.', '.', '2', '.'},
            //    {'2', '.', '.', '.', '.', '.', '7', '.', '.'},
            //    {'.', '.', '.', '2', '.', '.', '.', '.', '5'},
            //    {'.', '6', '.', '.', '.', '.', '2', '.', '.'} };

            //Sudoku_Solver ss = new Sudoku_Solver();
            //ss.SolveSudoku(su);

            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        Console.Write(su[i, j] +",");
            //    }
            //    Console.Write(Environment.NewLine);
            //}


        }
    }
}
