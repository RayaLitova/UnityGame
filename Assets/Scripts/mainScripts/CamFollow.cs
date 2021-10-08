using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{

    public GameObject target;
    public Vector3 offset;

    void Start(){

        target = GameObject.Find("Player");
    }

    void FixedUpdate()
    {
        transform.position=target.transform.position + offset;
    }
}
