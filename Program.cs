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
            //Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. 
            //An island is surrounded by water and is formed by connecting adjacent lands horizontally 
            //or vertically. You may assume all four edges of the grid are all surrounded by water.
            var numIslandOrCluster = new NumberIslandsOrClusters();
            char[,] grid = new char[,] { { '1', '1', '1', '1', '0' }, { '1', '1', '0', '1', '0' }, { '1', '1', '0', '0', '0' }, { '0', '0', '0', '0', '0' } };
            Console.WriteLine("Number of Islands or Clusters : {0}",numIslandOrCluster.NumIslands(grid));
            grid = new char[,] { { '1', '1', '0', '0', '0' }, { '1', '1', '0', '0', '0' }, { '0', '0', '1', '0', '0' }, { '0', '0', '0', '1', '1' } };
            Console.WriteLine("Number of Islands or Clusters : {0}", numIslandOrCluster.NumIslands(grid));
            Console.WriteLine("Time Complexity: O(n)");
            Console.WriteLine("Space Complexity: O(n)");

            //Given a binary tree, return the zigzag level order traversal of its nodes' values. 
            //(ie, from left to right, then right to left for the next level and alternate between).
            Console.WriteLine("Print the list of Zig Zag Level Order Traversal");
            var zigZagLevelOrder = new ZigZagLevelOrder();
            zigZagLevelOrder.root = new TreeNode(3);
            zigZagLevelOrder.root.left = new TreeNode(9);
            zigZagLevelOrder.root.right = new TreeNode(20);
            zigZagLevelOrder.root.right.left = new TreeNode(15);
            zigZagLevelOrder.root.right.right = new TreeNode(7);
             var results = zigZagLevelOrder.ZigZagOrder(zigZagLevelOrder.root);
            foreach(var result in results)
            {
                foreach(var r in result)
                    Console.WriteLine(r);
            }
            Console.WriteLine("Time Complexity: O(n^2)");
            Console.WriteLine("Space Complexity: O(1)");

            Console.ReadKey();
        }
    }
}
