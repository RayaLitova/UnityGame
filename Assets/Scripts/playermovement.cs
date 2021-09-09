using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    
    public float MvSpeed;
    public Rigidbody2D rb;

    private Vector2 moveDir;
    public Animator animator;


    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDir= new Vector2(moveX,moveY).normalized;
        
        if(moveDir.sqrMagnitude>0){
            animator.SetFloat("Horizontal", moveY);
            animator.SetFloat("Vertical", moveX);
        }

        animator.SetFloat("Speed", moveDir.sqrMagnitude);


    }

    void FixedUpdate(){
        rb.velocity = new Vector2(moveDir.x * MvSpeed, moveDir.y * MvSpeed); 
    }
}
