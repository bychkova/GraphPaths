using System;
using System.Collections.Generic;

namespace graphPath
{
    class Graph
    {
        List<Vertex> Vertexes = new List<Vertex>();
        List<Edge> Edges = new List<Edge>();

        //количество вершин и ребер
        public int VertexCount => Vertexes.Count;
        public int EdgeCount => Edges.Count;

        //добавление вершины к списку вершин
        public void AddVertex(Vertex vertex)
        {
            Vertexes.Add(vertex);
        }

        //добавление ребра к списку ребер
        public void AddEdge(Vertex from, Vertex to)
        {
            var edge = new Edge(from, to);
            Edges.Add(edge);
        }

        //метод создания матрицы смежности

        public int[,] GetMatrix()
        {
            int[,] matrix = new int[Vertexes.Count, Vertexes.Count]; //инициализация квадратной матрицы

            foreach (var edge in Edges) //проход по каждому ребру
            {
                var row = edge.From.VertexID;
                var column = edge.To.VertexID;

                matrix[row, column] = 1; // на пересечении 1
            }

            return matrix;
        }
    }
}
