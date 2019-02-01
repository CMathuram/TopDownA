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
    private Animator anim;

    void Start () {
        healthE = StarthealthE;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //Attack();
     
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        InvokeRepeating("Attack", 1, 1);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        CancelInvoke("Attack");
    }

    public void Attack()
    {
        Debug.Log("Player under attack");

            healthE -= 10;
            PlayerHealth.fillAmount = healthE / StarthealthE;
            Stab.Play();
        anim.SetTrigger("Hurt");

    //Player's Health
    Debug.Log("Player Health " + healthE);
            if (healthE <= 0)
            {
                Destroy(gameObject);
            }
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
