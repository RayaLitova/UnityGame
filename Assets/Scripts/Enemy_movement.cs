using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using System;

public class Enemy_movement : MonoBehaviour
{

    public AIPath aiPath;
    public Animator animator;

    public GameObject target;
    public Seeker seeker;

    public int startX;
    public int startY;

    private int patroolX = 0;
    private int patroolY = 0;
    private bool isPartooling = true;
    private bool isAttacking = false;

    private Vector2 nextPatroolWaypoint;

    private void change_x_y(){
        if(patroolX == 1 && patroolY == 0){
            patroolX = 0;
            patroolY = 1;
        }else if(patroolX == 0 && patroolY == 1){
            patroolX = -1;
            patroolY = 0;
        }else if(patroolX == -1 && patroolY == 0){
            patroolX = 0;
            patroolY = -1;
        }else if(patroolX == 0 && patroolY == -1){
            patroolX = 1;
            patroolY = 0;
        }else{
            patroolX = 1;
            patroolY = 0;
        }

        nextPatroolWaypoint = new Vector2((float)Math.Floor(transform.position.x + patroolX*4), (float)Math.Floor(transform.position.y + patroolY*4));
    }

    void Start(){
        change_x_y();
    }

    void Update()
    {
        if(Vector2.Distance(new Vector2(startX, startY), target.transform.position)<=0.1f){
            Debug.Log("a");
            isAttacking = true;
            isPartooling = false;
            aiPath.enabled = false;
            animator.SetFloat("Speed", 0);

        }else if(Vector2.Distance(new Vector2(startX, startY), target.transform.position)<=7f){
            isAttacking = false;
            isPartooling = false;
            aiPath.enabled = true;
            animator.SetFloat("Speed", 1);
            
        }else{
            animator.SetFloat("Speed", 1);
            isAttacking = false;
            aiPath.enabled = false;
            if(!isPartooling){
                transform.position = Vector2.MoveTowards(transform.position, new Vector2(startX, startY), 0.01f);
            }
            if((Vector2)transform.position == new Vector2(startX, startY)){
                isPartooling = true;
            }
        }

        if(isPartooling){
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(nextPatroolWaypoint.x+(float)(transform.position.x-Math.Floor(transform.position.x)),nextPatroolWaypoint.y+(float)(transform.position.y-Math.Floor(transform.position.y))), 0.01f);

            if(Math.Floor(transform.position.x) == nextPatroolWaypoint.x && Math.Floor(transform.position.y) == nextPatroolWaypoint.y){
                change_x_y();
            }
        }

        if(isAttacking){
            
            InvokeRepeating("attack", 2f, 2f);

        }

        if(animator.GetFloat("Speed")>0.01){
            if(aiPath.enabled){
                animator.SetFloat("X", aiPath.desiredVelocity.x);
                animator.SetFloat("Y", aiPath.desiredVelocity.y);
            }else if(isPartooling){
                animator.SetFloat("X", patroolX);
                animator.SetFloat("Y", patroolY);
            }else{
                animator.SetFloat("X", startX - transform.position.x);
                animator.SetFloat("Y", startY - transform.position.y);
            }

        }

        
    }

    void attack(){
        Debug.Log(Time.time);
    }
}
