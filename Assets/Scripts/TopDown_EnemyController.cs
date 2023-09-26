using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown_EnemyController : MonoBehaviour
{
    Vector3 prevPos;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = transform.position - prevPos;

        if (Mathf.Abs(movement.x) > Mathf.Abs(movement.y))
        {
            if (movement.x > 0f)
            {
                anim.SetInteger("Direction", 0);
            }
            if (movement.x < 0f)
            {
                anim.SetInteger("Direction", 2);
            }
        }
        else
        {
            if (movement.y > 0f)
            {
                anim.SetInteger("Direction", 1);
            }
            if (movement.y < 0f)
            {
                anim.SetInteger("Direction", 3);
            }
        }

        prevPos = transform.position;

        if (Input.GetMouseButton(0))
        {
            Attack();
        }
    }

    // Call this function from another script for the orc to attack!
    public void Attack()
    {
        anim.SetTrigger("Attack");
    }
}
