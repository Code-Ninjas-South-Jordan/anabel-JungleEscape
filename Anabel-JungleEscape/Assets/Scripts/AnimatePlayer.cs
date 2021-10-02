using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    Jump jump;
    void Start()
    {
        animator = GetComponent<Animator>();    
        jump = GetComponent<Jump>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!jump.isGrounded)
        {
            animator.SetBool("isJumping", true);
            animator.SetBool("isWalking", false);
            animator.SetBool("isIdle", false);
            animator.SetBool("isWalkingBackwards", false);
        }
        else
        {
            animator.SetBool("isJumping", false);
            animator.SetBool("isWalking", false);
            animator.SetBool("isIdle", true);
            animator.SetBool("isWalkingBackwards", false);
            if(Input.GetAxisRaw("Vertical") == 1)
            {
                animator.SetBool("isIdle", false);
                animator.SetBool("isWalking", true);
            }
            else if(Input.GetAxisRaw("Vertical") == -1)
            {
                animator.SetBool("isIdle", false);
                animator.SetBool("isWalkingBackwards", true);
            }
            if(!Input.anyKey)
            {
                animator.SetBool("isJumping", false);
                animator.SetBool("isWalking", false);
                animator.SetBool("isIdle", true);
                animator.SetBool("isWalkingBackwards", false);
            }
        
        }
    }
}
