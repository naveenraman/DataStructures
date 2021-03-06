﻿using LearnDataStructure.ArraysAndStrings;
using LearnDataStructure.TreeAndGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numIslandOrCluster = new NumberIslandsOrClusters();
            //char[,] grid = new char[,] { { '1', '1', '1', '1', '0' }, { '1', '1', '0', '1', '0' }, { '1', '1', '0', '0', '0' }, { '0', '0', '0', '0', '0' } };
            //Console.WriteLine("Number of Islands or Clusters : {0}",numIslandOrCluster.NumIslands(grid));
            //grid = new char[,] { { '1', '1', '0', '0', '0' }, { '1', '1', '0', '0', '0' }, { '0', '0', '1', '0', '0' }, { '0', '0', '0', '1', '1' } };
            //Console.WriteLine("Number of Islands or Clusters : {0}", numIslandOrCluster.NumIslands(grid));
            //Console.WriteLine("Time Complexity: O(n^2)");
            //Console.WriteLine("Space Complexity: O(1)");

            //Console.WriteLine("Print the list of Zig Zag Level Order Traversal");
            //var zigZagLevelOrder = new ZigZagLevelOrder();
            //zigZagLevelOrder.root = new TreeNode(3);
            //zigZagLevelOrder.root.left = new TreeNode(9);
            //zigZagLevelOrder.root.right = new TreeNode(20);
            //zigZagLevelOrder.root.right.left = new TreeNode(15);
            //zigZagLevelOrder.root.right.right = new TreeNode(7);
            // var results = zigZagLevelOrder.ZigZagOrder(zigZagLevelOrder.root);
            //foreach(var result in results)
            //{
            //    foreach(var r in result)
            //        Console.WriteLine(r);
            //}
            //Console.WriteLine("Time Complexity: O(n^2)");
            //Console.WriteLine("Space Complexity: O(1)");

            //WordLadderProblem wordLadderProblem = new WordLadderProblem();
            //Console.WriteLine(wordLadderProblem.LadderLength("hit", "cog", new List<string> { "hot", "dot", "dog", "lot", "log","cog" }));
            //BasicCalculatorII bCalc = new BasicCalculatorII();
            //Console.WriteLine(bCalc.Calculate("3+2*2"));
            //SlidingWindowMaximum slidingWindowMaximum = new SlidingWindowMaximum();
            //Console.WriteLine(String.Join(",", slidingWindowMaximum.MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3)));
            ConcatenatedWords cw = new ConcatenatedWords();
            cw.FindAllConcatenatedWordsInADict(new string[] { "cat", "cats", "catsdogcats", "dog", "dogcatsdog", "hippopotamuses", "rat", "ratcatdogcat" });
            Console.ReadKey();
        }
    }
}
