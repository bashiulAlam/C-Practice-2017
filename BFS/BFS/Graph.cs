using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    class Graph
    {
        private int numOfVertex;
        private int numOfEdge;

        public void addEdge(Dictionary<int, int> list, int m, int n)
        {
            list.Add(m, n);
        }

        public void printEdge(Dictionary<int, int> list)
        {
            foreach (var pair in list)
                Console.WriteLine(pair.Key + ", " + pair.Value);
        }
    }
}
