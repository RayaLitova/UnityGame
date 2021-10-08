using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takebox : MonoBehaviour
{
    public GameObject weapon;
    public Renderer weapon_rend;
    public BoxCollider2D collider;
    public GameObject player;


    void Start(){
        player = GameObject.Find("Player");
        weapon = GameObject.Find("Wand1");
        weapon_rend = weapon.GetComponent<Renderer>();
    }

    public void OnCollisionEnter2D(Collision2D other){
        Debug.Log("a");
        SampleScene_stage.isWandTaken = true;
        PlayerStats.inventory.Add("weapon", weapon);
        Debug.Log(PlayerStats.inventory);
        Destroy(gameObject, 0.3f);
        weapon.transform.parent = player.transform;
        weapon.transform.position = (Vector2)player.transform.position + new Vector2(0.6f, -0.3f);
        Destroy(weapon.GetComponent<BoxCollider2D>());
        weapon_rend.enabled = true;
        collider.enabled = true;
        if(playermovement.moveX!=-1)
            weapon.transform.Rotate(new Vector2(0,180)); 
    }
}
