using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Node
    {
        public int count = 0;
        public String label;
        public List<Edge> edges;

        public Node(string label)
        {
            this.label = label;
            edges = new List<Edge>();
        }

        public Node RandomTravel()
        {
            Random r = new Random();
            return edges[r.Next(edges.Count())].destination;

        }

        public override string ToString()
        {
            return label + ": " + count;
        }

    }
}
