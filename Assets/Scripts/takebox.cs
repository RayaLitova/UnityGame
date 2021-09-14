using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takebox : MonoBehaviour
{
    public GameObject weapon;
    public Renderer weapon_rend;
    public BoxCollider2D collider;
    public GameObject player;

    private void OnCollisionEnter2D(Collision2D other){
        Destroy(gameObject, 0.3f);
        weapon.transform.parent = player.transform;
        weapon.transform.position = (Vector2)player.transform.position + new Vector2(0.6f, -0.3f);
        Destroy(weapon.GetComponent<BoxCollider2D>());
        weapon_rend.enabled = true;
        collider.enabled = true;
        weapon.transform.Rotate(new Vector2(0,180)); 
    }
}
