using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyPlayer : MonoBehaviour
{
    void Start()
    {
        Debug.Log(GameObject.FindGameObjectsWithTag("Player").Length);
        if(GameObject.FindGameObjectsWithTag("Player").Length<=Statics.PlayerObjectCount){
            DontDestroyOnLoad(gameObject);
        }else{  
            Destroy(gameObject);
        }
        
    }
}
