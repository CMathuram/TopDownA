using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

    public float speed;
    private Transform target;
    private Animator anim;

    public AudioSource Fstep;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}
    
    void Update () {
        if (Vector2.Distance(transform.position, target.position) <= 3)
        {
            if (Vector2.Distance(transform.position, target.position) > 1)
            {
                //Fstep.Play(); // Sound Effect
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                anim.SetTrigger("Spot");
                
                //Debug.Log("Halt player");
            }
        }
        else
        {
            anim.SetTrigger("Idle");
        }    
	}
}
