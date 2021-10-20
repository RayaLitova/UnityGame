using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    void OnEnable(){
        Physics2D.IgnoreCollision(GameObject.Find("Player").GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }
    void OnCollisionEnter2D(Collision2D collision){
        Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        HouseSceneStatus.CanAttack = true;
    } 
 
    void OnCollisionExit2D(Collision2D other) {
        HouseSceneStatus.CanAttack = false;
    }
}
