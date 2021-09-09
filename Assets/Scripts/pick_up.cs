using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pick_up : MonoBehaviour
{
    void OnMouseUp()
    {
        Destroy(gameObject);
    }
}
