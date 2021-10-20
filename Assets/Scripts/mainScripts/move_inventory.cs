using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_inventory : MonoBehaviour
{
    private Vector2 mousePos;
    private float delX, delY;


    private void OnMouseDown(){
        Debug.Log("press");
        delX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        delY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
    }

    private void OnMouseDrag(){
        Debug.Log("Drag");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePos.x - delX, mousePos.y - delY);
    }

    void OnCollisionEnter2D(Collision2D collision){
         if(collision.gameObject.layer == 0 || collision.gameObject.layer == 13){
             Physics2D.IgnoreCollision( collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    } 
}
