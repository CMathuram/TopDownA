using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyCollBoss : MonoBehaviour
{
    private float speed;
    private Transform targetE;
    public AudioSource AttackSound;
    private float health;
    private int attack = 0;

    GameObject EnemyObject;

    [Header("Enemy Health")]
    public Image healthBar;
    public float Starthealth = 100;

    void Start()
    {
        health = Starthealth;
    }

    void Update()
    {
        targetE = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        if (Vector2.Distance(transform.position, targetE.position) > 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, transform.position, speed * Time.deltaTime);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            attack = 1;
        }
    }


    public void OnMouseDown()
    {
        if (attack == 1)
        {
            health -= 1;
            AttackSound.Play();
            Debug.Log("Collision detected --> Player");
            healthBar.fillAmount = health / Starthealth;
            if (health <= 0)
            {
                //Death animation here
                Destroy(gameObject);
            }
        }
    }

    public void EnemyCount()
    {
        Debug.Log("Enemy Name " + EnemyObject);
    }

}