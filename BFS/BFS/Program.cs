using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, int> list = new Dictionary<int, int>();
            Boolean [ , ] list = new Boolean[4, 4];
            int numOfVertex;
            int numOfEdge;

            //Console.WriteLine("Number of edges : ");
            //numOfVertex = Convert.ToInt32(Console.ReadLine());

            BFS bfs = new BFS(4);

            Graph g = new Graph();
            g.addEdge(list, 0, 1);
            g.addEdge(list, 0, 2);
            g.addEdge(list, 1, 2);
            g.addEdge(list, 2, 0);
            g.addEdge(list, 2, 3);
            g.addEdge(list, 3, 3);

            bfs.BFSTraversal(list, 3);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
