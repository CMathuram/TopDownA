
using System.Collections.Generic;
using UnityEngine;

public class graph {
    public int rows = 0;
    public int cols = 0;
    public Node[] nodes;
    
    public graph(int[,] grid)
    {
        rows = grid.GetLength(0);
        cols = grid.GetLength(1);

        nodes = new Node[grid.Length];
        for(var i = 0; i < nodes.Length; i++)
        {
            var node = new Node();
            node.label = i.ToString();
            nodes[i] = node;
        }
        for (var r=0; r < rows; r++){
            for (var c = 0; c < rows; c++)
            {
                var node = nodes[cols * r + c];

                if(grid[r, c] == 1){
                    continue;
                }

                //up

                if (r > 0)
                {
                    node.adjecent.Add(nodes[cols * (r - 1) + c]);
                }

                //right
                if (c < cols-1)
                {
                    node.adjecent.Add(nodes[cols *r + c+1]);
                }

                //down
                if (r < rows-1)
                {
                    node.adjecent.Add(nodes[cols * (r + 1) + c]);
                }
                //left
                if (c > 0)
                {
                    node.adjecent.Add(nodes[cols*r+c-1]);
                }

            }
           
            }

    }


}
