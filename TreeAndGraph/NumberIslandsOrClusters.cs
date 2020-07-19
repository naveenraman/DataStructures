using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.TreeAndGraph
{
    public class NumberIslandsOrClusters
    {
		public int NumIslands(char[,] grid)
		{
			if (grid == null || grid.Length == 0)
			{
				return 0;
			}
			int rowCount = grid.GetLength(0);
			int colCount = grid.GetLength(1);
			var visited = new bool[rowCount, colCount];
			int islandCount = 0;
			for (int i = 0; i < rowCount; i++)
			{
				for (int j = 0; j < colCount; j++)
				{
					if (grid[i, j] == '1' && visited[i, j] == false)
					{
						islandCount++;
						CheckAdjacent(grid, visited, i, j, rowCount, colCount);
					}
				}
			}
			return islandCount;
		}
		private void CheckAdjacent(char[,] grid, bool[,] visited, int i, int j, int rowCount, int colCount)
		{
			if ((i >= 0 && i < rowCount) &&
			   (j >= 0 && j < colCount) &&
			   visited[i, j] == false)
			{
				visited[i, j] = true;
				if (grid[i, j] == '1')
				{
					CheckAdjacent(grid, visited, i + 1, j, rowCount, colCount);
					CheckAdjacent(grid, visited, i, j + 1, rowCount, colCount);
					CheckAdjacent(grid, visited, i - 1, j, rowCount, colCount);
					CheckAdjacent(grid, visited, i, j - 1, rowCount, colCount);
				}
			}
		}

	}
}
