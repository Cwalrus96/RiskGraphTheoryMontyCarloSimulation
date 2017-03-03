using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Graph
    {
        List<Node> nodes;
        String label; 

        public Graph(String label)
        {
            this.label = label;
            nodes = new List<Node>(); 
        }
    }
}
