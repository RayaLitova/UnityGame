using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statics : MonoBehaviour
{
    public static string SceneToLoad;

    void Start(){
        DontDestroyOnLoad(gameObject);
    }
    
}
