using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public bool overworld;
    float xspeed;
    float xdirection;
    float xvector;
    float yspeed;
    float ydirection;
    float yvector;
    private void Start()
    {
        GetComponentInChildren<TopDown_AnimatorController>().enabled = overworld;
        GetComponentInChildren<Platformer_AnimatorController>().enabled = !overworld; //what do you think ! means?
        float xspeed = 4;
        float xvector = 0;
        float xdirection = 0;
        float yspeed = 4;
        float yvector = 0;
        float ydirection = 0;

        if (overworld)
        {
            GetComponent<Rigidbody2D>().gravityScale = 0f;
        }
        else
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }

    private void Update()
    {
        xdirection = Input.GetAxis("horizontal");
        {
            xvector = xspeed * xdirection;

        }
        ydirection = Input.GetAxis("vertical");
        {
            yvector = yspeed * ydirection;
        }
    }
    //for organization, put other built-in Unity functions here
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coin"));

        Destroy(other.gameObject);
            }
     void OnCollisionEnter2D(Collision2D other)
      {
        if (other.gameObject.CompareTag("wall"));
        {
            print("we hit wall");
                }
    }






    //after all Unity functions, your own functions can go here
}