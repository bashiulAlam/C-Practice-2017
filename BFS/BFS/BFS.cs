using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    class BFS
    {
        private int numOfVertex;
        private int numOfEdge;

        public BFS(int V)
        {
            numOfVertex = V;
        }

        public void BFSTraversal(Dictionary<int, int> list, int startNode)
        {
            Boolean[] isVisited = new Boolean[numOfVertex];
            for (int i = 0; i < numOfVertex; i++)
                isVisited[i] = false;

            Queue<int> queue = new Queue<int>();

            isVisited[startNode] = true;
            queue.Enqueue(startNode);

            while (queue.Count != 0)
            {
                int current = queue.Dequeue();
                Console.Write(current + " ");

                foreach (var pair in list)
                {
                    if (pair.Key == current)
                    {
                        int next = pair.Value;
                        if (!isVisited[next])
                        {
                            isVisited[next] = true;
                            queue.Enqueue(next);
                        }
                    }
                }
            }
        }
    }
}
