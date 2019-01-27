using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class PathFindingTest : MonoBehaviour {

    public GameObject mapGroup;
    private Transform Apoint;
    private PathFindingEnd pathfindingend;
    private PathFindingStart pathfindingstart;

    int startpoint;
    int endpoint;

    void Awake()
    {
        pathfindingend = GameObject.FindObjectOfType<PathFindingEnd>();
        pathfindingstart = GameObject.FindObjectOfType<PathFindingStart>();
    }

    // Use this for initialization
   public void Start () {

        startpoint = pathfindingend.temp;
        
        //startpoint = 5;

        int[,] map = new int[5, 5]
        {
            {0,1,0,0,0 },
            {0,1,0,0,0 },
            {0,1,0,0,0 },
            {0,1,0,0,0 },
            {0,0,0,0,0 }
        };
        var graph = new graph(map);
        var search = new search(graph);
        //endpoint = 0;
        //startpoint = 23; 
        // Apoint = enemyfollow.target;
        //Debug.Log("StartPoint = " + startpoint);
        //Debug.Log("EndPoint " + endpoint);

        search.start(graph.nodes[endpoint], graph.nodes[startpoint]);

        while (!search.finished)
        {
            search.Step();
        }
      //  print("Search done.Path Length " + search.path.Count + " iterations" + search.iterations);

        ResetMapGroup(graph);

        foreach (var node in search.path)
        {
            GetImage(node.label).color = node.adjecent.Count == 0 ? Color.white : Color.white;
        }

        foreach (var node in search.path)
        {
            GetImage(node.label).color = Color.red;
        }
        
		
	}


    Image GetImage(string label)
    {
        var id = Int32.Parse(label);
        var go = mapGroup.transform.GetChild(id).gameObject;
        return go.GetComponent<Image>();

    }

    private void ResetMapGroup(graph graph2)
    {
        foreach(var node in graph2.nodes)
        {
           // GetImage(node.label).color = node.adjecent.Count == 0 ? Color.white : Color.grey;
        }
    }
    

    // Update is called once per frame
   // void Update () {
      //  int a = enemyfollow.target;
	//}
}
