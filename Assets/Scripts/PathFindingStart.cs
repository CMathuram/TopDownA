using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFindingStart : MonoBehaviour
{

    private PathFindingTest pathfindingtest;

    public int tempstart;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        //InvokeRepeating("OnCollisionEnter2D", 3, 3);
   
    }

    void Awake()
    {
        pathfindingtest = GameObject.FindObjectOfType<PathFindingTest>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.gameObject.tag == "Enemy")
        //{
        //    Debug.Log(gameObject.name);
        //}
        tempstart = Int32.Parse(other.gameObject.name);
        //temp = other.gameObject.name;
        //Debug.Log(temp);


        Color myColor = GetComponent<Renderer>().material.color;
        if (myColor.Equals(Color.red))
        {
            Debug.Log("MOVE");
        }

        pathfindingtest.Start();
    }
}

