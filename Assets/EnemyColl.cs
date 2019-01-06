using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyColl : MonoBehaviour {

    Mouse mousectrl;

    public float Starthealth = 100;
    public float health;
    

    [Header("Unity Stuff")]
    public Image healthBar;
    
    void Start()
    {
        health = Starthealth;    
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "Tree")
        //{
        //    //  collision.gameObject.SendMessage("ApplyDamage", 10);
        //    Debug.Log("Collision detected --> Tree");
        //}

        if (collision.gameObject.tag == "Player")
        {
            OnMouseDown();
        }

        Debug.Log(health);
        if(health <= 0)
        {
            //Death animation here
            Destroy(gameObject);
        }
    }
    public void OnMouseDown()
    {
        Debug.Log("Mouse Click");

        //  collision.gameObject.SendMessage("ApplyDamage", 10);
        health -= 10;
        Debug.Log("Collision detected --> Player");
        healthBar.fillAmount = health / Starthealth;

    }

}

public class Mouse
{
    EnemyColl EC;
    
}
