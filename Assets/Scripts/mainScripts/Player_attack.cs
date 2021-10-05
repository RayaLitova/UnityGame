using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_attack : MonoBehaviour
{
    public static bool allowFight = false;
    private float nextActionTime=1f;
    private float period = 1f;

    void Update()
    {
        if(allowFight){
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null){
                Debug.Log(hit.collider.gameObject.name);
                if(hit.collider.gameObject.tag=="enemy"){
                    if (Time.time > nextActionTime){
                        if(Input.GetMouseButtonDown(0)){
                            nextActionTime = Time.time+period;
                            basic_attack.Attack(gameObject, hit.collider.gameObject);
                        }
                        
                    }
                }
            }

        }else{
            nextActionTime=Time.time+period;
        } 
    }
}
