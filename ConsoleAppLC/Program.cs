﻿using System;
using static ConsoleAppLC.Remove_Nth_Node_From_End_of_List;

namespace ConsoleAppLC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Wildcard_Matching wm = new Wildcard_Matching();
            Console.WriteLine(wm.IsMatch2("abcabczzzde", "*abc???de*"));
           

            //Trapping_Rain_Water trw = new Trapping_Rain_Water();
            //Console.WriteLine(trw.Trap2(new int[] { 4, 2, 0, 3, 2, 5 }));

            //Combination_Sum cs = new Combination_Sum();
            //Console.WriteLine(cs.CombinationSum(new int[] { 2, 3, 5, 7}, 7));

            //Count_and_Say ca = new Count_and_Say();
            //Console.WriteLine(ca.CountAndSay(7));
            //Multiply_Strings ms = new Multiply_Strings();
            //Console.WriteLine(ms.Multiply("123", "0"));


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

            //Valid_Sudoku vs = new Valid_Sudoku();
            //Console.WriteLine(vs.IsValidSudoku(su));

            //Find_First_and_Last_Position_of_Element_in_Sorted_Array ff = new Find_First_and_Last_Position_of_Element_in_Sorted_Array();
            //Console.WriteLine(ff.SearchRange(new int[] { 2, 2 }, 3));

            //Search_in_Rotated_Sorted_Array si = new Search_in_Rotated_Sorted_Array();
            //Console.WriteLine(si.Search(new int[] { 1,3 }, 3));
            //Longest_Valid_Parentheses lv = new Longest_Valid_Parentheses();
            //Console.WriteLine(lv.LongestValidParentheses(""));
            //Next_Permutation np = new Next_Permutation();
            //np.NextPermutation(new int[] { 1, 3, 2, 2, 1});

            //Substring_with_Concatenation_of_All_Words sw = new Substring_with_Concatenation_of_All_Words();
            //sw.FindSubstring("wordgoodgoodgoodbestword", new string[] { "word", "good", "best", "good" });

            //Merge_k_Sorted_Lists ms = new Merge_k_Sorted_Lists();
            //Remove_Nth_Node_From_End_of_List rn = new Remove_Nth_Node_From_End_of_List();
            //ms.MergeKLists(new ListNode[] { });

            //Reverse_Nodes_in_k_Group rnk = new Reverse_Nodes_in_k_Group();
            //Remove_Nth_Node_From_End_of_List rn = new Remove_Nth_Node_From_End_of_List();
            //var x = rn.ArrayToList(new int[] { 1 });
            //rnk.ReverseKGroup(x, 1);

            //Generate_Parentheses gp = new Generate_Parentheses();
            //Console.WriteLine(gp.GenerateParenthesis(8));
            //Remove_Nth_Node_From_End_of_List rn = new Remove_Nth_Node_From_End_of_List();
            //var x = rn.ArrayToList(new int[] { 1, 2, 3, 4, 5 });
            //rn.RemoveNthFromEnd(x, 5);

            //Letter_Combinations_of_a_Phone_Number lc = new Letter_Combinations_of_a_Phone_Number();
            //var x = lc.LetterCombinations("");
            //Console.WriteLine(x);

            //_3Sum_Closest s = new _3Sum_Closest();
            //var x = s.ThreeSumClosest(new int[] { 1, 1, -1, -1, 3 }, -1);
            //Console.WriteLine(x);

            //_3Sum s = new _3Sum();
            //var x = s.ThreeSum(new int[] {});
            //Console.WriteLine(x);

            //Integer_to_Roman itr = new Integer_to_Roman();
            //Console.WriteLine(itr.IntToRoman(1));

            //Container_With_Most_Water cw = new Container_With_Most_Water();
            //Console.WriteLine(cw.MaxArea(new int[] { 1, 3, 0, 4, 5, 1 }));

            //Palindrome_Number pn = new Palindrome_Number();
            //Console.WriteLine(pn.IsPalindrome(-12321));

            //String_to_Integer si = new String_to_Integer();
            //Console.WriteLine(si.MyAtoi(" "));

            //Reverse_Integer ri = new Reverse_Integer();
            //Console.WriteLine(ri.Reverse(int.MaxValue));

            //ZigZag_Conversion zc = new ZigZag_Conversion();
            //var x = zc.Convert("ab", 1);
            //Console.WriteLine(x);

            //Longest_Substring_Without_Repeating_Characters ls = new Longest_Substring_Without_Repeating_Characters();
            //var x = ls.LengthOfLongestSubstring("abba");
            //Console.WriteLine(x);

            //Add_Two_Numbers atn = new Add_Two_Numbers();
            //var a1 = atn.ArrayToList(new int[] { 2,4,9});
            //var a2 = atn.ArrayToList(new int[] { 5,6,4,9});
            //var ret = atn.AddTwoNumbers(a1, a2);

        }
}
}