using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Edge
    {
        public Node source;
        public Node destination;

        public Edge(Node source, Node destination)
        {
            this.source = source;
            this.destination = destination;
        }
    }
}
