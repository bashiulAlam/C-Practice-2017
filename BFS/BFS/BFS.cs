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

        public void BFSTraversal(Boolean[ , ] list, int startNode)
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
                int next;

                for (int i = 0; i < numOfVertex; i++)
                {
                    if (list[current, i])
                    {
                        next = i;
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
