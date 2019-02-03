using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cherry : MonoBehaviour {

    float Health = 0;
    private EnemyCombatBoss enemycombatboss;
    public AudioSource cherrypick;

    // Use this for initialization
    void Start()
    {
       
    }

    void Awake()
    {
        enemycombatboss = GameObject.FindObjectOfType<EnemyCombatBoss>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("Cherry"))
        {
            //Debug.Log("Starting coin Script");
            Health = Health + 20;
            enemycombatboss.HealthVal(Health);
            cherrypick.Play();
            other.gameObject.SetActive(false);
            Health = 0;
        }
    }
}
