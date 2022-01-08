using System;
namespace graphPath
{
    class Vertex
    {
        public int VertexID { get; set; } //идентификатор вершины

        public Vertex(int number)
        {
            VertexID = number;
        }

        public override string ToString()
        {
            return VertexID.ToString();
        }
    }
}
