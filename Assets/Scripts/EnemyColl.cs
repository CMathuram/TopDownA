using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyColl : MonoBehaviour
{
    private float speed;
    private Transform targetE;
    public AudioSource AttackSound;
    private float health;
    private int attack = 0;
    int combo;

    GameObject EnemyObject;

    [Header("Enemy Health")]
    public Image healthBar;
    public float Starthealth = 100;
    

    void Start()
    {
        health = Starthealth;
        Cursor.visible = false;
    }

    void Awake()
    {
        
    }

    void Update()
    {
        targetE = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        if (Vector2.Distance(transform.position, targetE.position) > 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, transform.position, speed * Time.deltaTime);
        }

       
        if (attack == 1)
        {
            InvokeRepeating("MouseLeftClick", 0, 3);
            InvokeRepeating("MouseRightClick", 0, 3);
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.tag == "Player")
        {
              attack = 1;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            attack = 0;
            CancelInvoke("MouseLeftClick");
            CancelInvoke("MouseRightClick");
        }
    }

    public void MouseLeftClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left Click");
            health -= 10;
            AttackSound.Play();
            Debug.Log("Collision detected --> Player");
            healthBar.fillAmount = health / Starthealth;
            if (health <= 0)
            {
                //gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    } 

    public void MouseRightClick()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Right Click");
            health -= 30;
            AttackSound.Play();
            Debug.Log("Collision detected --> Player");
            healthBar.fillAmount = health / Starthealth;
            if (health <= 0)
            {
                //gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }

    //public void OnMouseDown()

}