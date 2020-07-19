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
            var numIslandOrCluster = new NumberIslandsOrClusters();

            char[,] grid = new char[,] { { '1', '1', '1', '1', '0' }, { '1', '1', '0', '1', '0' }, { '1', '1', '0', '0', '0' }, { '0', '0', '0', '0', '0' } };
            Console.WriteLine("Number of Islands or Clusters : {0}",numIslandOrCluster.NumIslands(grid));

            grid = new char[,] { { '1', '1', '0', '0', '0' }, { '1', '1', '0', '0', '0' }, { '0', '0', '1', '0', '0' }, { '0', '0', '0', '1', '1' } };
            Console.WriteLine("Number of Islands or Clusters : {0}", numIslandOrCluster.NumIslands(grid));

            Console.ReadKey();

        }
    }
}
