using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyPlayer : MonoBehaviour
{
    void Start()
    {
        if(gameObject.tag=="Player"){
            if(GameObject.FindGameObjectsWithTag("Player").Length<=Statics.PlayerObjectCount){
                DontDestroyOnLoad(gameObject);
            }else{  
                Destroy(gameObject);
            }
        }else if(gameObject.tag=="MainCamera"){
            if(GameObject.FindGameObjectsWithTag("MainCamera").Length<=1){
                DontDestroyOnLoad(gameObject);
            }else{  
                Destroy(gameObject);
            }
        }
        
    }
}
