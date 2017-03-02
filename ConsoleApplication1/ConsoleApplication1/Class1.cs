using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Node
    {
        int count = 0; 
        string label;
        List<Edge> edges;

        public Node(string label)
        {
            this.label = label;
            edges = new List<Edge>();
        }

        public Node RandomTravel()
        {
            Random r = new Random();
            return edges[Math.Round((double)(r.Next(edges.Count()))];

        }
    }
}
