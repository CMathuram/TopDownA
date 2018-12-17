using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyColl : MonoBehaviour {

    public float Starthealth = 100;
    private float health;

    [Header("Unity Stuff")]
    public Image healthBar;

    void Start()
    {
        health = Starthealth;    
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Tree")
        {
            //  collision.gameObject.SendMessage("ApplyDamage", 10);
            Debug.Log("Collision detected --> Tree");
        }
        if (collision.gameObject.tag == "Player")
        {
            //  collision.gameObject.SendMessage("ApplyDamage", 10);
            health -= 10;
            Debug.Log("Collision detected --> Player");
            healthBar.fillAmount = health / Starthealth;
           
        }
    }
}
