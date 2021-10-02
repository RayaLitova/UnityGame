using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class playermovement : MonoBehaviour
{
    
    public float MvSpeed;
    public Rigidbody2D rb;

    private Vector2 moveDir;
    private float oldDirX;
    public Animator animator;

    public GameObject weapon;
    public Renderer weapon_rend;

    private bool once = true;
    
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDir= new Vector2(moveX,moveY).normalized;
        if(oldDirX != moveX) once = true;
        else once = false;

        if(moveX!=0)
            oldDirX = moveX;
        
        if(moveDir.sqrMagnitude>0){
            animator.SetFloat("Horizontal", moveY);
            animator.SetFloat("Vertical", moveX);
        }

        animator.SetFloat("Speed", moveDir.sqrMagnitude);

        if(weapon_rend.enabled){
            if(moveX==-1){
                if(once){
                    weapon.transform.Rotate(new Vector2(0,180)); 
                    once = false;
                }
                weapon.transform.position = new Vector2(transform.position.x - 0.6f, weapon.transform.position.y);
            }else if(moveX==1){
                if(once){
                    weapon.transform.Rotate(new Vector2(0,180)); 
                    once = false;
                }
                weapon.transform.position = new Vector2(transform.position.x + 0.6f, weapon.transform.position.y);
            }
        }
    }

    void FixedUpdate(){
        rb.velocity = new Vector2(moveDir.x * MvSpeed, moveDir.y * MvSpeed); 

        foreach(GameObject target in GameObject.FindGameObjectsWithTag("enemy")){
            if(Vector2.Distance(target.transform.position, transform.position)<=2){
                Fight(target);
                break;
            }
        }
    }

    float nextActionTime = 0f;
    float period = 1f;

    private void Fight(GameObject target){
        if (Time.time > nextActionTime){
            nextActionTime += period;
            basic_attack.Attack(gameObject, target);
        }

    }
}
