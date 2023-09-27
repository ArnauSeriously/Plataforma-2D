using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{

    public bool isGrounded;

    private Animator animator;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 6)
        {
            isGrounded = true;
            animator.SetBool("isJumping", false);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.layer == 6)
        {
            isGrounded = false;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.layer == 6 )
        {
            isGrounded = true;
        }
    }

    void Start()
    {
        animator=GameObject.Find("rogue").GetComponent<Animator>();
    
    }
}
