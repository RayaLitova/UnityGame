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
    private float oldDirX = 1;
    public Animator animator;

    public GameObject weapon;
    public Renderer weapon_rend;

    private bool once = true;

    private float nextActionTime = 2f;
    private float period = 1f;

    public static float moveX;
    public static float moveY;

    private bool isFighting = false;

    
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
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

        if(!isFighting) nextActionTime=Time.time+period;
    }

    void FixedUpdate(){
        rb.velocity = new Vector2(moveDir.x * MvSpeed, moveDir.y * MvSpeed); 

        foreach(GameObject target in GameObject.FindGameObjectsWithTag("enemy")){
            if(Vector2.Distance(target.transform.position, transform.position)<=2){
                isFighting = true;
                Fight(target);
                break;
            }else{
                isFighting=false;
            }
        }
    }

    

    private void Fight(GameObject target){
        if (Time.time > nextActionTime){
            nextActionTime += period;
            basic_attack.Attack(gameObject, target);
        }

    }
}
