using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.ImageEffects;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour {

    
    private Animator anim;

    void Start()
    {
          anim = GetComponent<Animator>();
    }

    void Update () {
        int PlayerHealth = 10;
        Vector3 movement = new Vector3(CrossPlatformInputManager.GetAxisRaw("Horizontal"), CrossPlatformInputManager.GetAxisRaw("Vertical"), 0.0f);
        transform.position = transform.position + movement * Time.deltaTime;
        var x = Input.GetAxisRaw("Horizontal");


     // var x =  this.transform.Translate(CrossPlatformInputManager.GetAxis("Horizontal") * MovX * Time.deltaTime, 0, 0);

        if (x < 0)
        {
            anim.SetTrigger("Trig");
            GetComponent<Transform>().eulerAngles = new Vector3(0,-180,0);
        }

        if (x > 0)
        {
            anim.SetTrigger("Trig");
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
            
        }

        if (PlayerHealth == 0)
        {
            movement = new Vector3(0, 0, 0.0f);
            transform.position = new Vector3(0, 0, 0);
        }

    
    }

}
