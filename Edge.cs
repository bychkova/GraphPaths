using System;
namespace graphPath
{
    class Edge
    {
        public Vertex From { get; set; }
        public Vertex To { get; set; }

        public Edge(Vertex from, Vertex to)
        {
            From = from;
            To = to;
        }

        public override string ToString()
        {
            return $"({From}; {To})";
        }
    }
}
