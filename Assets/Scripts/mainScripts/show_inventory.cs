using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_inventory : MonoBehaviour
{
    private bool isShown = false;
    public Renderer inventory;
    public BoxCollider2D collider;

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.I)){
            isShown=!isShown;
            inventory.enabled = isShown;
            collider.enabled = isShown;
        } 
    }
}
