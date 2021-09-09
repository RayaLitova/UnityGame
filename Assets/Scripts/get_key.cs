using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_key : MonoBehaviour
{
    public GameObject player;

    void OnMouseDown()
    {
        transform.parent = player.transform;
        transform.position = (Vector2)player.transform.position + new Vector2(0.1f, 0.7f);
        Destroy(gameObject.GetComponent<BoxCollider2D>());

    }
}
