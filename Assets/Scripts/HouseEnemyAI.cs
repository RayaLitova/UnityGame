using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseEnemyAI : MonoBehaviour
{
    
    private GameObject player;
    private Transform charge;
    private Transform projectile;

    private float nextActionTime = 2f;
    private float period = 1.5f;

    private bool isStopped = false;

    void Start(){  
        charge = transform.GetChild(0);
        //projectile = transform.GetChild(1);
        player = GameObject.Find("Player");
        
    }

    void Update(){
        if(!isStopped){
            if(Vector2.Distance(transform.position, player.transform.position)<=3){
                StartCoroutine(ChargeAttack());
            }else{
                transform.position = Vector2.MoveTowards(transform.position, player.transform.position, 0.005f);
            }
        }     
    }

    void Attack(){
        charge.GetComponent<Renderer>().enabled = false;
        //collision with projectile
        if(Vector2.Distance(transform.position, player.transform.position)<=3){
            basic_attack.Attack(gameObject, player);
        }
        isStopped = false;

    }
    IEnumerator ChargeAttack(){
        while(!check())
            charge.RotateAround(transform.position, new Vector3(0,0,1), 1f); 
        charge.GetComponent<Renderer>().enabled = true;
        isStopped = true;
        yield return new WaitForSeconds(3);
        Attack();
    }

    bool check(){
        bool A=Mathf.Round(player.transform.position.x - charge.position.x) / Mathf.Round(transform.position.x - charge.position.x) == Mathf.Round(player.transform.position.y - charge.position.y) / Mathf.Round(transform.position.y - charge.position.y);
        Vector2 medianPoint = (player.transform.position + transform.position) / 2f;
        bool X = (charge.position.x>=transform.position.x) == (medianPoint.x>=transform.position.x);
        bool Y = (charge.position.y>=transform.position.y) == (medianPoint.y>=transform.position.y);
        return A && (X && Y);
    }
}