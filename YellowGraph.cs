using System;
using System.Collections.Generic;

class YellowGraph : Graph
{

    // List of nodes in this graph
    private List<Node> nodes;

    // An adjacency matrix, recording edges between nodes
    // Edge FROM node i to node j is recorded in adjMatrix[i,j]
    // Each int entry records the edge cost (> -1)
    // If entry is 0 there is no edge 
    private int[,] adjMatrix;

    public YellowGraph()
    {
        nodes = new List<Node>();
        adjMatrix = new int[1, 1];
    }


    public void AddNode(Node a)//added 1
    {

        nodes.Add(a);
        int[] newArray; //created a new array to hold the values of 'nodes'
        newArray = new int[nodes]; //fill the array of ints with list
        adjMatrix.Add(newArray,0);

        for (int i = 0; i < nodes.Count; i++)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                newArray[0] = 0;
                adjMatrix[i,j].Add(0,0);
            }
        }

    }

    public void AddEdge(Node a, Node b, int c)
    {

        int nodeA = nodes.IndexOf(a);
        int nodeB = nodes.IndexOf(b);
        adjMatrix[nodeA][nodeB] = c;
    }

    public List<Node> Neighbours(Node a)
    {
        return nodes;
    }

    public int Cost(Node a, Node b)
    {
        return adjMatrix[nodes.IndexOf(a)][nodes.IndexOf(b)];
    }

    public void Write()
    {
        Console.WriteLine("YellowGraph");

        for (int i = 0; i < nodes.Count; i++)
        {
            Console.Write(nodes[i] + ": ");

            bool first = true;
            for (int j = 0; j < nodes.Count; j++)
            {
                if (adjMatrix[i, j] > 0)
                {
                    if (!first) Console.Write(", ");
                    Console.Write(nodes[j] + "(" + adjMatrix[i, j] + ")");
                    first = false;
                }
            }

            Console.Write("\n");
        }
    }
}

