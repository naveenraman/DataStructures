﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.TreeAndGraph
{
    //Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. 
    //An island is surrounded by water and is formed by connecting adjacent lands horizontally 
    //or vertically. You may assume all four edges of the grid are all surrounded by water.
    //Time complexity : O(n^2).
    //Space complexity : O(1).
    public class NumberIslandsOrClusters
    {
        //public int NumIslands(char[,] grid)
        //{
        //    if (grid == null || grid.Length == 0)
        //    {
        //        return 0;
        //    }
        //    int rowCount = grid.GetLength(0);
        //    int colCount = grid.GetLength(1);
        //    var visited = new bool[rowCount, colCount];
        //    int islandCount = 0;
        //    for (int i = 0; i < rowCount; i++)
        //    {
        //        for (int j = 0; j < colCount; j++)
        //        {
        //            if (grid[i, j] == '1' && visited[i, j] == false)
        //            {
        //                islandCount++;
        //                CheckAdjacent(grid, visited, i, j, rowCount, colCount);
        //            }
        //        }
        //    }
        //    return islandCount;
        //}
        //private void CheckAdjacent(char[,] grid, bool[,] visited, int i, int j, int rowCount, int colCount)
        //{
        //    if ((i >= 0 && i < rowCount) &&
        //       (j >= 0 && j < colCount) &&
        //       visited[i, j] == false)
        //    {
        //        visited[i, j] = true;
        //        if (grid[i, j] == '1')
        //        {
        //            CheckAdjacent(grid, visited, i + 1, j, rowCount, colCount);
        //            CheckAdjacent(grid, visited, i, j + 1, rowCount, colCount);
        //            CheckAdjacent(grid, visited, i - 1, j, rowCount, colCount);
        //            CheckAdjacent(grid, visited, i, j - 1, rowCount, colCount);
        //        }
        //    }
        //}
        public int NumIslands(char[,] grid)
        {
            int islandCount = 0;
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }
            int rowCount = grid.GetLength(0);
            int colCount = grid.GetLength(1);
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (grid[i, j] == '1')
                    {
                        islandCount++;
                        CheckAdjacent(grid, i, j);
                    }
                }
            }
            return islandCount;
        }
        private void CheckAdjacent(char[,] grid, int i, int j)
        {
            if (i < 0 || j < 0 ||
                i >= grid.GetLength(0) ||
                j >= grid.GetLength(1) ||
                grid[i, j] != '1')
                return;
            grid[i, j] = '2';
            CheckAdjacent(grid, i + 1, j);
            CheckAdjacent(grid, i - 1, j);
            CheckAdjacent(grid, i, j - 1);
            CheckAdjacent(grid, i, j + 1);
        }
    }
}
