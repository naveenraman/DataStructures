using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.TreeAndGraph
{
    public class CriticalConnectionsInANetwork
    {
        private List<int>[] adjList;
        private int[] dfsOrder;
        private int[] reachable;
        private List<List<int>> bridges;
        public List<List<int>> CriticalConnections(int n, List<List<int>> connections)
        {
            adjList = new List<int>[n];
            foreach (var connection in connections)
            {
                int from = connection[0];
                int to = connection[1];
                if (adjList[from] == null)
                    adjList[from] = new List<int>();
                if (adjList[to] == null)
                    adjList[to] = new List<int>();
                adjList[from].Add(to);
                adjList[to].Add(from);
            }
            dfsOrder = new int[n];
            reachable = new int[n];
            bridges = new List<List<int>>();
            int counter = 1;
            Traverse(0, 0, ref counter);
            return bridges;
        }
        private void Traverse(int node, int parent, ref int counter)
        {
            if (dfsOrder[node] != 0)
                return;
            reachable[node] = dfsOrder[node] = counter++;
            foreach (int next in adjList[node])
            {
                if (next != parent)
                {
                    Traverse(next, node, ref counter);
                    reachable[node] = Math.Min(reachable[node], Math.Min(reachable[next], dfsOrder[next]));
                    if (reachable[next] > dfsOrder[node])
                        bridges.Add(new List<int> { next, node });
                }
            }
        }
    }
}
