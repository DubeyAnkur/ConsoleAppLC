using System;
using static ConsoleAppLC.Remove_Nth_Node_From_End_of_List;

namespace ConsoleAppLC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Gray_Code gc = new Gray_Code();
            gc.GrayCode(3);
            //Merge_Sorted_Array ms = new Merge_Sorted_Array();
            //ms.Merge(new int[] { 2, 0 }, 1, new int[] { 1 }, 1);

            //Scramble_String ss = new Scramble_String();
            //Console.WriteLine(ss.IsScramble("abc", "bca"));

            //Partition_List pl = new Partition_List();
            //var b = new ListNode(2, null);
            //var a = new ListNode(5, b);
            //var z = new ListNode(2, a);
            //var y = new ListNode(3, z);
            //var x = new ListNode(4, y);
            //ListNode head = new ListNode(1, x);
            //pl.Partition(head, 3);

            //Maximal_Rectangle mr = new Maximal_Rectangle();
            //char[][] board = new char[3][] { new char[] { '1', '1', '0', '1' }, new char[] { '1', '1', '0', '1' }, new char[] { '1', '1', '1', '1' }};
            //Console.WriteLine(mr.MaximalRectangle(board));

            //Largest_Rectangle_in_Histogram lr = new Largest_Rectangle_in_Histogram();
            //Console.WriteLine(lr.LargestRectangleArea(new int[] { 2, 1, 5, 6, 2, 3 }));
            //Remove_Duplicates_from_Sorted_Array_II rd = new Remove_Duplicates_from_Sorted_Array_II();
            //rd.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 });

            //Search_in_Rotated_Sorted_Array_II sr = new Search_in_Rotated_Sorted_Array_II();
            //Console.WriteLine(sr.Search(new int[]{1, 1, 1, 1, 1, 1, 1, 1, 12, 13, 1, 1, 1}, 13));
            //Remove_Duplicates_from_Sorted_List_II rd = new Remove_Duplicates_from_Sorted_List_II();
            //var c = new ListNode(5, null);
            //var b = new ListNode(4, c);
            //var a = new ListNode(4, b);
            //var z = new ListNode(3, a);
            //var y = new ListNode(3, z);
            //var x = new ListNode(2, y);
            //ListNode head = new ListNode(1, x);
            //rd.DeleteDuplicates(head);

            //Word_Search ws = new Word_Search();
            //char[][] board = new char[3][] { new char[]{ 'A', 'B', 'C', 'E' }, new char[] { 'S', 'F', 'C', 'S' }, new char[] { 'A', 'D', 'E', 'E' } };
            //Console.WriteLine(ws.Exist(board, "ABCB"));

            //Subsets1 s = new Subsets1();
            //s.Subsets(new int[] { 1,2,3});

            //Minimum_Window_Substring mw = new Minimum_Window_Substring();
            //Console.WriteLine(mw.MinWindow("ADOBECODEBANC", "ABC"));

            //Combinations c = new Combinations();
            //c.Combine(5, 3);

            //Sort_Colors sc = new Sort_Colors();
            //sc.SortColors(new int[] { 2, 0, 2, 1, 1, 0});

            //Search_a_2D_Matrix sm = new Search_a_2D_Matrix();
            //var matrix = new int[1][] { new int[] { 1 } };
            //Console.WriteLine(sm.SearchMatrix(matrix, 2));

            //Set_Matrix_Zeroes sm = new Set_Matrix_Zeroes();
            //int[][] mat = new int[3][] {
            //    new int[] { 0,1,2,0},
            //    new int[] { 3,4,5,2},
            //    new int[] { 1,3,1,5}
            //};
            //sm.SetZeroes(mat);

            //Edit_Distance ed = new Edit_Distance();
            //Console.WriteLine(ed.MinDistance("zoogeologist", "zoologicoarchaeologist"));

            //Text_Justification tj = new Text_Justification();
            //tj.FullJustify(new string[] { "ask", "not", "what", "your", "country", "can", "do", "for", "you", "ask", "what", "you", "can", "do", "for", "your", "country"},16);
            //Valid_Number vn = new Valid_Number();
            //Console.WriteLine(vn.IsNumber("."));

            //Minimum_Path_Sum mp = new Minimum_Path_Sum();
            //int[][] m = new int[][] { 
            //    new int[] { 1,3,1},
            //    new int[] { 1, 5, 1},
            //    new int[] { 4, 2, 1}
            //};
            //Console.WriteLine(mp.MinPathSum(m));

            //Rotate_List rl = new Rotate_List();

            //var y = new ListNode(2, null);
            //var x = new ListNode(1, y);
            //ListNode head = new ListNode(0, null);
            //rl.RotateRight(x, 1);

            //Unique_Paths up = new Unique_Paths();
            //Console.WriteLine(up.UniquePaths(23, 12));

            //Permutation_Sequence ps = new Permutation_Sequence();
            //Console.WriteLine(ps.GetPermutation(4, 9));
            //Spiral_Matrix_II sm2 = new Spiral_Matrix_II();
            //sm2.GenerateMatrix(3);

            //Length_of_Last_Word ll = new Length_of_Last_Word();
            //Console.WriteLine(ll.LengthOfLastWord(" a"));

            //int[][] a = new int[][] {
            //    new int[] {2, 5 },
            //    new int[] {6, 7 },
            //    new int[] {8, 9 }
            //};
            //Insert_Interval ii = new Insert_Interval();
            //ii.Insert(a, new int[] { 0,1});

            //Merge_Intervals mi = new Merge_Intervals();

            //int[][] data = new int[][] {
            //    new int[] {1,4},
            //    new int[] {0,4}
            //};

            //mi.Merge(data);

            //Jump_Game jg = new Jump_Game();
            //Console.WriteLine(jg.CanJump(new int[] { 3, 2, 1, 0, 4 }));

            //int[,] twoD = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            //Spiral_Matrix sm = new Spiral_Matrix();
            //sm.SpiralOrder(twoD);

            //N_Queens n_Queens = new N_Queens();
            //var x = 5;
            //var t = n_Queens.SolveNQueens(x);
            //foreach (var a in t)
            //{
            //    foreach (var b in a)
            //    {
            //        Console.WriteLine(b);
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            //Pow p = new Pow();
            //Console.WriteLine(p.MyPow(-1, int.MinValue));

            //int[][] matrix = { { 1,2,3},{ 4,5,6},{ 7,8,9} };
            //Rotate_Image ri = new Rotate_Image();
            //ri.Rotate(matrix);

            //Group_Anagrams ga = new Group_Anagrams();
            //ga.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });

            //Permutations_II p = new Permutations_II();
            //var x = p.Permute(new int[] { 1, 1, 1, 2 });

            //Jump_Game_II jg = new Jump_Game_II();
            //Console.WriteLine(jg.Jump3(new int[] { 2, 3, 1, 1, 4 }));

            //Wildcard_Matching wm = new Wildcard_Matching();
            //Console.WriteLine(wm.IsMatch2("abcabczzzde", "*abc???de*"));

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
