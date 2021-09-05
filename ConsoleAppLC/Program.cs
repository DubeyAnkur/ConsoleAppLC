using System;
using System.Collections;
using System.Collections.Generic;
using static ConsoleAppLC.Remove_Nth_Node_From_End_of_List;

namespace ConsoleAppLC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Russian_Doll_Envelopes rd = new Russian_Doll_Envelopes();

            int[][] env = new int[6][];
            env[0] = new int[] { 1, 3 };
            env[1] = new int[] { 3, 5 };
            env[2] = new int[] { 6, 7 };
            env[3] = new int[] { 6, 8 };
            env[4] = new int[] { 8, 4 };
            env[5] = new int[] { 9, 5 };

            Console.WriteLine(rd.MaxEnvelopes(env));
            //Maximum_Points_You_Can_Obtain_from_Cards mp = new Maximum_Points_You_Can_Obtain_from_Cards();
            //Console.WriteLine(mp.MaxScore(new int[] { 1, 2, 3, 4, 5, 6, 1 }, 3));
            //Count_of_Smaller_Numbers_After_Self co = new Count_of_Smaller_Numbers_After_Self();
            //co.CountSmaller(new int[] { 26, 78, 27, 100, 33, 67, 90, 23, 66, 5, 38, 7, 35, 23, 52, 22, 83, 51, 98, 69, 81, 32, 78, 28, 94, 13, 2, 97, 3, 76, 99, 51, 9, 21, 84, 66, 65, 36, 100, 41});


            //Dictionary<int, List<string>> dict = new Dictionary<int, List<string>>();

            //Longest_Increasing_Path_in_a_Matrix li = new Longest_Increasing_Path_in_a_Matrix();
            //int[][] mat = new int[3][];
            //mat[0] = new int[] { 9, 9, 4 };
            //mat[1] = new int[] { 6, 6, 8 };
            //mat[2] = new int[] { 2, 1, 1 };
            //Console.WriteLine(li.LongestIncreasingPath(mat));
            //Accounts_Merge am = new Accounts_Merge();
            //var lst = new List<IList<string>>();
            //lst.Add(new List<string>() { "Alex", "Alex5@m.co", "Alex4@m.co", "Alex0@m.co" });
            //lst.Add(new List<string>() { "Ethan", "Ethan3@m.co", "Ethan3@m.co", "Ethan0@m.co" });
            //lst.Add(new List<string>() { "Kevin", "Kevin4@m.co", "Kevin2@m.co", "Kevin2@m.co" });
            //lst.Add(new List<string>() { "Gabe", "Gabe0@m.co", "Gabe3@m.co", "Gabe2@m.co" });
            //lst.Add(new List<string>() { "Gabe", "Gabe3@m.co", "Gabe4@m.co", "Gabe2@m.co" });

            //am.AccountsMerge(lst);

            //int[] x = new int[10];
            //Array.Fill(x, -1);
            //Word_Search_II ws = new Word_Search_II();

            //char[][] board = new char[4][];
            //board[0] = new char[] { 'a', 'a', 'a', 'a' };
            //board[1] = new char[] { 'a', 'a', 'a', 'a' };
            //board[2] = new char[] { 'a', 'h', 'k', 'r' };
            //board[3] = new char[] { 'a', 'f', 'l', 'v' };

            //string[] words = new string[] { "aa", "aaa", "aaaa", "rain" };
            //ws.FindWords(board, words);

            //House_Robber_II hr = new House_Robber_II();
            //Console.WriteLine(hr.Rob(new int[] { 1, 3, 1, 3, 100 }));
            //Guess_the_Word cw = new Guess_the_Word();
            //string[] dict = new string[] { "acckzz", "ccbazz", "eiowzz", "abcczz" };
            //cw.FindSecretWord(dict);

            //Course_Schedule_II cs = new Course_Schedule_II();
            //int[][] pre = new int[3][];
            //pre[0] = new int[] { 0, 2 };
            //pre[1] = new int[] { 1, 2 };
            //pre[2] = new int[] { 2, 0 };
            //Console.WriteLine(cs.FindOrder(3, pre));
            //Max_Area_of_Island ma = new Max_Area_of_Island();

            //int[][] grid = new int[2][];
            //grid[0] = new int[] { 0, 1 };
            //grid[1] = new int[] { 0, 1 };

            //Console.WriteLine(ma.MaxAreaOfIsland(grid));

            //Random_Pick_with_Weight rp = new Random_Pick_with_Weight(new int[] { 3,14,1,7});

            //Console.WriteLine(rp.PickIndex());
            //Console.WriteLine(rp.PickIndex());
            //Console.WriteLine(rp.PickIndex());

            //Console.WriteLine(rp.PickIndex());
            //Console.WriteLine(rp.PickIndex());
            //Console.WriteLine(rp.PickIndex());

            //Console.WriteLine(rp.PickIndex());
            //Console.WriteLine(rp.PickIndex());
            //Console.WriteLine(rp.PickIndex());

            //LFUCache lfu = new LFUCache(0);
            //lfu.Put(0, 0);  
            //lfu.Get(0);

            //Course_Schedule cs = new Course_Schedule();
            //int[][] arr = new int[5][];
            //arr[0] = new int[] { 2,0};
            //arr[1] = new int[] { 1, 0 };
            //arr[2] = new int[] { 3, 1 };
            //arr[3] = new int[] { 3, 2 };
            //arr[4] = new int[] { 1, 3 };

            //Console.WriteLine(cs.CanFinish(4, arr));

            //Strong_Password_Checker sp = new Strong_Password_Checker();
            //Console.WriteLine(sp.StrongPasswordChecker("aaaabbbbccccddeeddeeddeedd"));

            //Rotate_Array ra = new Rotate_Array();
            //ra.Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21}, 29);
            //Repeated_DNA_Sequences r = new Repeated_DNA_Sequences();
            //r.FindRepeatedDnaSequences("ACTACTACTACTACTACTACTACTACTACT");

            //Largest_Number ln = new Largest_Number();
            //Console.WriteLine(ln.LargestNumber(new int[] { 4312, 7645, 98, 8323, 7452, 9659, 569, 4153, 5222, 2323, 7189, 9469, 4907, 7692, 9354, 7048, 8080, 3020, 6921, 6868, 6764, 3576, 6107, 7475, 2066, 9189, 3992, 983, 3703, 8152, 7171, 6628, 9718, 2004, 4763, 4294, 2448, 4920, 2099, 3932, 7025, 6764, 3650, 4581, 2884, 7130, 3088, 7126, 7720, 3062, 970, 7698, 5825, 8828, 5746, 9273, 6341, 9749, 968, 1629, 6254, 7840, 4114, 7518, 7291, 8554, 545, 6209, 321, 5754, 4114, 7038, 6711, 7231, 8983, 5997, 7095, 3448, 9712, 7735, 2339, 7501, 1380, 6625, 6394, 3563, 2857, 6665, 7732, 6778, 2419, 9820, 2839, 5798, 4992, 2321, 3443, 2919, 2659, 55}));
            //Fraction_to_Recurring_Decimal fr = new Fraction_to_Recurring_Decimal();
            //Console.WriteLine(fr.FractionToDecimal(7, -12));

            //Maximum_Gap mg = new Maximum_Gap();
            //mg.MaximumGap(new int[] { 1 });

            //Palindrome_Partitioning_II pp = new Palindrome_Partitioning_II();
            //Console.WriteLine(pp.MinCut("abaaaaabba"));

            //["LRUCache","put","put","get","put","get","put","get","get","get"]
            //[[2],[1,0],[2,2],[1],[3,3],[2],[4,4],[1],[3],[4]]

            //Max_Points_on_Line mp = new Max_Points_on_Line();
            //int[][] points = new int[6][];
            //points[0] = new int[] { -184, -551 };
            //points[1] = new int[] { -105,-467};
            //points[2] = new int[] { -90,-394};
            //points[3] = new int[] { -60,-248};
            //points[4] = new int[] { 115, 359};
            //points[5] = new int[] { 138, 429};
            //points[6] = new int[] { 60, 336};
            //points[7] = new int[] { 150, 774};
            //points[8] = new int[] { 207, 639};
            //points[9] = new int[] { -150,-686};
            //points[10] = new int[] { -135,-613};
            //points[11] = new int[] { 92, 289};
            //points[12] = new int[] { 23, 79};
            //points[13] = new int[] { 135, 701};
            //points[14] = new int[] { 0, 9};
            //points[15] = new int[] { -230,-691};
            //points[16] = new int[] { -115,-341};
            //points[17] = new int[] { -161,-481};
            //points[18] = new int[] { 230, 709};
            //points[19] = new int[] { -30,-102};

            //points[0] = new int[] { 1,1 };
            //points[1] = new int[] { 3,2};
            //points[2] = new int[] { 5,3};
            //points[3] = new int[] { 4,1};
            //points[4] = new int[] { 2,3};
            //points[5] = new int[] { 1,4};

            //mp.MaxPoints(points);


            //LRUCache obj = new LRUCache(2);
            //obj.Put(2, 1);
            //obj.Put(1, 1);            
            //obj.Put(2, 3);
            //obj.Put(4, 1);
            //Console.WriteLine(obj.Get(1));
            //Console.WriteLine(obj.Get(2));

            //Binary_Tree_Postorder_Traversal bt = new Binary_Tree_Postorder_Traversal();

            //var l2 = new TreeNode(6, null, null);
            //var r2 = new TreeNode(7, null, null);

            //var l1 = new TreeNode(4, null, null);
            //var r1 = new TreeNode(5, null, null);

            //var l = new TreeNode(2, l1, r1);
            //var r = new TreeNode(3, l2, r2);
            //var root = new TreeNode(1, l, r);
            //bt.PostorderTraversal(root);


            //Copy_List_with_Random_Pointer cl = new Copy_List_with_Random_Pointer();

            //Copy_List_with_Random_Pointer.Node two = new Copy_List_with_Random_Pointer.Node(2);
            //Copy_List_with_Random_Pointer.Node one = new Copy_List_with_Random_Pointer.Node(1);
            //one.next = two;
            //one.random = two;
            //two.random = two;
            //cl.CopyRandomList(one);

            //Word_Break_II wb = new Word_Break_II();
            //wb.WordBreak("catsanddog", new List<string>() { "cat", "cats", "and", "sand", "dog" });
            //Candy1 c = new Candy1();
            //Console.WriteLine(c.Candy(new int[] { 1, 0, 2}));

            //Word_Break wb = new Word_Break();
            //Console.WriteLine(wb.WordBreak("leetcode", new List<string>() { "leet","code"}));

            //Single_Number_II sn = new Single_Number_II();
            //Console.WriteLine(sn.SingleNumber(new int[] { 30000, 500, 100, 30000, 100, 30000, 100 }));

            //Clone_Graph cg = new Clone_Graph();
            //Clone_Graph.Node one = new Clone_Graph.Node(1, new List<Clone_Graph.Node>());
            //Clone_Graph.Node two = new Clone_Graph.Node(2, new List<Clone_Graph.Node>());
            //Clone_Graph.Node three = new Clone_Graph.Node(3, new List<Clone_Graph.Node>());
            //Clone_Graph.Node four = new Clone_Graph.Node(4, new List<Clone_Graph.Node>());
            //one.neighbors.Add(two);
            //one.neighbors.Add(four);

            //two.neighbors.Add(one);
            //two.neighbors.Add(three);

            //three.neighbors.Add(two);
            //three.neighbors.Add(four);

            //four.neighbors.Add(one);
            //four.neighbors.Add(three);

            //cg.CloneGraph(one);

            //Palindrome_Partitioning_II pp = new Palindrome_Partitioning_II();
            //Console.WriteLine(pp.MinCut("aabbaaa"));
            //Surrounded_Regions sr = new Surrounded_Regions();
            //char[][] board = new char[2][];
            //board[0] = new char[] { 'X', 'O'};
            //board[1] = new char[] { 'O', 'X' };

            //sr.Solve(board);
            //Word_Ladder_II wl = new Word_Ladder_II();
            //wl.FindLadders("red", "tax", new List<string>() { "ted", "tex", "red", "tax", "tad", "den", "rex", "pee" });

            //Valid_Palindrome vp = new Valid_Palindrome();
            //Console.WriteLine(vp.IsPalindrome("A man, a plan, a canal: Panama"));

            //Binary_Tree_Maximum_Path_Sum bt = new Binary_Tree_Maximum_Path_Sum();
            //var l1 = new TreeNode(15, null, null);
            //var r1 = new TreeNode(7, null, null);

            //var l = new TreeNode(-2, null, null);
            //var r = new TreeNode(3, null, null);
            //var root = new TreeNode(1, l, r);
            //Console.WriteLine(bt.MaxPathSum(root));

            //Best_Time_to_Buy_and_Sell_Stock_IV b3 = new Best_Time_to_Buy_and_Sell_Stock_IV();
            //Console.WriteLine(b3.MaxProfit(3, new int[] { 2, 5, 7, 1, 4, 3, 1, 3, 7 }));
            //var lst = new List<IList<int>>();
            //lst.Add(new List<int>() { -7 });
            //Triangle t = new Triangle();
            //Console.WriteLine(t.MinimumTotal(lst));


            //Populating_Next_Right_Pointers_in_Each_Node_II bb = new Populating_Next_Right_Pointers_in_Each_Node_II();
            //var l6 = new Node(7, null, null, null);

            //var l5 = new Node(8, null, null, null);
            //var r5 = new Node(8, null, null, null);

            //var l4 = new Node(1, null, null, null);
            //var r4 = new N3ode(0, l6, null, null);

            //var l3 = new Node(2, null, null, null);

            //var l2 = new Node(9, null, null, null);
            //var r2 = new Node(1, l5, r5, null);

            //var l1 = new Node(0, l3, null, null);
            //var r1 = new Node(7, l4, r4, null);

            //var l = new Node(1, l1, r1, null);
            //var r = new Node(3, l2, r2, null);
            //var root = new Node(2, l, r, null);
            //var x = bb.Connect(root);
            //Console.WriteLine();

            //Construct_Binary_Tree_from_Inorder_and_Postorder_Traversal cb = new Construct_Binary_Tree_from_Inorder_and_Postorder_Traversal();
            //var ret = cb.BuildTree(new int[] { 1, 3, 4, 6, 7, 8, 10, 13, 14 }, new int[] { 1, 4, 7, 6, 3, 13, 14, 10, 8 });
            //Console.WriteLine(ret);

            //Recover_Binary_Search_Tree tr = new Recover_Binary_Search_Tree();
            //var l = new TreeNode(3, null, null);
            //var r = new TreeNode(1, null, null);
            //var root = new TreeNode(2, l, r);
            //tr.RecoverTree(root);

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
