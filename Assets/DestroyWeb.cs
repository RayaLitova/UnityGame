using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWeb : MonoBehaviour
{
    void Start()
    {
        if(HouseSceneStatus.SpidersKilled == HouseSceneStatus.maxSpiders)
            Destroy(gameObject);
        else if(!gameObject.GetComponent<Renderer>().enabled)
            gameObject.GetComponent<Renderer>().enabled = true;
    }
}
