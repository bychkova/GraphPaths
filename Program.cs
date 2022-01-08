using System;
using System.Collections.Generic;

namespace graphPath
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();
            //список вершин
            var v1 = new Vertex(1);
            var v2 = new Vertex(2);
            var v3 = new Vertex(3);
            var v4 = new Vertex(4);
            var v5 = new Vertex(5);
            var v6 = new Vertex(6);

            //добавляем вершины к списку вершин List<Vertex> Vertexes
            graph.AddVertex(v1);
            graph.AddVertex(v2);
            graph.AddVertex(v3);
            graph.AddVertex(v4);
            graph.AddVertex(v5);
            graph.AddVertex(v6);

            //добавляем ребра к списку ребер List<Edge> Edges
            graph.AddEdge(v1, v2);
            graph.AddEdge(v2, v1);
            graph.AddEdge(v1, v3);
            graph.AddEdge(v3, v1);
            graph.AddEdge(v1, v4);
            graph.AddEdge(v4, v1);
            graph.AddEdge(v3, v4);
            graph.AddEdge(v4, v3);
            graph.AddEdge(v4, v5);
            graph.AddEdge(v5, v4);
            graph.AddEdge(v5, v6);
            graph.AddEdge(v6, v5);

            //заполняем матрицу смежности
            int[,] matrix = graph.GetMatrix();

            for (int i = 1; i < graph.VertexCount; i++)
            {
                for (int j = 1; j < graph.VertexCount; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
