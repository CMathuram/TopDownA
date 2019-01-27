using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PathFindingEnd : MonoBehaviour {

    private PathFindingTest pathfindingtest;
    public int temp;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //InvokeRepeating("OnCollisionEnter2D", 3, 3);

    }

    void Awake()
    {
        pathfindingtest = GameObject.FindObjectOfType<PathFindingTest>();
    }
    //Image GetImage(string label)
    //{
    //    var id = Int32.Parse(label);
    //    var go = mapGroup.transform.GetChild(id).gameObject;
    //    return go.GetComponent<Image>();

    //}

    void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.gameObject.tag == "Enemy")
        //{
        //    Debug.Log(gameObject.name);
        //}
        temp = Int32.Parse(other.gameObject.name);
        //temp = other.gameObject.name;
        //Debug.Log(temp);
        //Debug.Log(GetComponent<Image>().color);
        //if(GetImage(node.label).color == Color.red)
        //{
        //    Debug.Log("Background is red");
        //}
        pathfindingtest.Start();
    }
    }

