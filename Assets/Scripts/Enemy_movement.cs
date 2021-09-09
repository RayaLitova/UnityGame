using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Enemy_movement : MonoBehaviour
{

    public AIPath aiPath;
    public Animator animator;

    public Rigidbody2D rb;

    public GameObject target;
    public Seeker seeker;

    public int startX;
    public int startY;

    void Update()
    {
        if(Vector2.Distance(transform.position, target.transform.position)<=5){
            aiPath.enabled = true;
            animator.SetFloat("Speed", 1);
            
        }else{
            aiPath.enabled = false;
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(startX, startY),0.01f);
            if((Vector2)transform.position == new Vector2(startX, startY)){
                animator.SetFloat("X", 0);
                animator.SetFloat("Y", -1);
                animator.SetFloat("Speed", 0);
            }
        }
        
        if(animator.GetFloat("Speed")>0.01){
            if(aiPath.enabled){
                animator.SetFloat("X", aiPath.desiredVelocity.x);
                animator.SetFloat("Y", aiPath.desiredVelocity.y);
            }else{
                animator.SetFloat("X", rb.velocity.x);
                animator.SetFloat("Y", rb.velocity.y);
            }

        }

        
    }
}
