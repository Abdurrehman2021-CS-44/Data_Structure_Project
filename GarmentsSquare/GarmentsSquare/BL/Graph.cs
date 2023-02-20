using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarmentsSquare.BL
{
    public class Graph
    {
        private List<Vertex> vertices;

        public List<Vertex> Vertices { get => vertices; set => vertices = value; }

        public Graph()
        {
            this.Vertices = new List<Vertex>();
        }

        public void addVertex(Vertex n)
        {
            Vertices.Add(n);
        }
        public void addDiEdge(Vertex u, Vertex v)
        {
            u.addOutNeighbour(v);
            v.addInNeighbour(u);
        }
        public void addBiEdge(Vertex u, Vertex v)
        {
            addDiEdge(u, v);
            addDiEdge(v, u);
        }
        public List<Tuple<Vertex, Vertex>> getDirEdges()
        {
            List<Tuple<Vertex, Vertex>> directed_edges = new List<Tuple<Vertex, Vertex>>();
            foreach (Vertex v in Vertices)
            {
                foreach (Vertex u in v.getOutNeighbours())
                {
                    var edge = Tuple.Create(v, u);
                    directed_edges.Add(edge);
                }
            }
            return directed_edges;
        }
        public string Print_Graph()
        {
            string ret = "Graph with:\n";
            ret += "\t Vertices:\n\t";
            foreach (Vertex v in this.Vertices)
            {
                ret += v.getVlue() + ",";
            }
            ret += "\n";
            ret += "\t Edges:\n\t";
            foreach (Tuple<Vertex, Vertex> edge in getDirEdges())
            {
                ret += "(" + edge.Item1.getVlue() + "," + edge.Item2.getVlue() + ") ";
            }
            ret += "\n";
            return ret;
        }
        public int DFS_helper(Vertex w, int currentTime, bool verbose)
        {
            if (verbose)
            {
                Console.WriteLine("Time", currentTime, ":\t entering", w);
            }
            w.InTime = currentTime;
            currentTime++;
            w.Status = "inprogress";
            foreach (Vertex v in w.getOutNeighbours())
            {
                if (v.Status == "unvisited")
                {
                    currentTime = DFS_helper(v, currentTime, verbose);
                    currentTime++;
                }
            }
            w.OutTime = currentTime;
            w.Status = "done";
            if (verbose)
            {
                Console.WriteLine("Time", currentTime, ":\t leaving", w);
            }
            return currentTime;
        }
        public int DFS(Vertex w, Graph G, bool verbose = false)
        {
            foreach (Vertex v in G.vertices)
            {
                v.Status = "unvisited";
                v.InTime = 0;
                v.OutTime = 0;
            }
            return DFS_helper(w, 0, verbose);
        }
        public int topoSort_helper(Vertex w, int currentTime, List<Tuple<int, Vertex>> orderings, bool verbose)
        {
            if (verbose)
            {
                Console.WriteLine("Time", currentTime, ":\t entering", w);
            }
            w.InTime = currentTime;
            currentTime++;
            w.Status = "inprogress";
            foreach (Vertex v in w.getOutNeighbours())
            {
                if (v.Status == "unvisited")
                {
                    currentTime = topoSort_helper(v, currentTime, orderings, verbose);
                    currentTime++;
                }
            }
            w.OutTime = currentTime;
            w.Status = "done";
            var order = Tuple.Create(0, w);
            orderings.Add(order);
            if (verbose)
            {
                Console.WriteLine("Time", currentTime, ":\t leaving", w);
            }
            return currentTime;
        }
        public List<Tuple<int, Vertex>> topoSort(Graph G, bool verbose = false)
        {
            Vertex w = G.vertices[0];
            List<Tuple<int, Vertex>> orderings = new List<Tuple<int, Vertex>>();
            foreach (Vertex v in G.vertices)
            {
                v.Status = "unvisited";
                v.InTime = 0;
                v.OutTime = 0;
            }
            topoSort_helper(w, 0, orderings, verbose);
            return orderings;
        }
        public static int lenght_of_vertices(Graph g)
        {
            int count = 0;
            foreach (Vertex v in g.vertices)
            {
                count++;
            }
            return count;
        }
        public Vertex[,] BFS(Vertex w, Graph G)
        {
            foreach (Vertex v in G.vertices)
            {
                v.Status = "unvisited";
            }
            int n = Graph.lenght_of_vertices(G);
            w.Status = "visited";
            Vertex[,] Ls = new Vertex[n, n];
            Ls[0, 0] = w;
            for (int i = 0; i < n; i++)
            {

            }
            return Ls;
        }
    }
}
