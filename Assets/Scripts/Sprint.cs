using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sprint : MonoBehaviour {

    public Image SprintBar;
    private float Startsprintmeter = 10;
    private float sprint;
    private float speed = 0;
    private PlayerMovement playermovement;

	// Use this for initialization
	void Start () {

        sprint = Startsprintmeter;

    }

    void Awake()
    {
        playermovement = GameObject.FindObjectOfType<PlayerMovement>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (sprint > 0)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (sprint == 0)
                {
                    speed = 0.1f;
                    playermovement.playermove(speed);
                }
                else
                {
                    //Debug.Log("Shift Pressed");
                    sprint -= 0.50f;
                    speed = 5f;
                    SprintBar.fillAmount = sprint / Startsprintmeter;
                    playermovement.playermove(speed);
                }

                //Debug.Log("Sprint = " + sprint);
            }
            else
            {
                sprint += 0.2f;
                speed = 1f;
                SprintBar.fillAmount = sprint / Startsprintmeter;
                playermovement.playermove(speed);
                
            }
        }
        else
        {
            sprint += 0.2f;
            speed = 1f;
            SprintBar.fillAmount = sprint / Startsprintmeter;
            playermovement.playermove(speed);
            
        }
        }
    
}
