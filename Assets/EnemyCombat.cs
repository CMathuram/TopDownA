using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCombat : MonoBehaviour {

    [Header("Player Health")]
    public Image PlayerHealth;
    public float StarthealthE = 100;
    private float healthE;
    public AudioSource Stab;

    //    int combat = 0, EAttack = 0;

    // Use this for initialization
    void Start () {
        healthE = StarthealthE;
    }

    void Update()
    {
        //Attack();
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        InvokeRepeating("Attack", 3, 1);
        //combat = Random.Range(1, 5);
        //if (collision.gameObject.tag == "Enemy")
        //{
        //    if (combat % 2 == 0)
        //    {
        //        EAttack = 1;
        //        //Debug.Log("Eattack"+ combat);
        //    }
        //}
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        CancelInvoke("Attack");
    }

    public void Attack()
    {
        Debug.Log("Player under attack");

       // if (EAttack == 1)
       // {
            healthE -= 10;
            PlayerHealth.fillAmount = healthE / StarthealthE;
            Stab.Play();

    //Player's Health
    Debug.Log("Player Health " + healthE);
            if (healthE <= 0)
            {
                //Death animation here
                Destroy(gameObject);
            }
        //}
     }

    public void HealthVal(float Health)
    {
        healthE += Health;
        PlayerHealth.fillAmount = healthE / StarthealthE;
        Debug.Log("Medic " + healthE);

        if(healthE > 100)
        {
            healthE = 100;
        }
    }
}
