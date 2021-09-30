using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statics : MonoBehaviour
{
    public static string SceneToLoad;
    public static int StaticFilesCount;

    void Start(){
        if(GameObject.FindGameObjectsWithTag("StaticTag").Length<=StaticFilesCount){
            DontDestroyOnLoad(gameObject);
        }else{  
            Destroy(gameObject);
        }
    }
    
}
