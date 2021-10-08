using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statics : MonoBehaviour
{
    public static string SceneToLoad;
    public static int StaticFilesCount = 4;
    public static int PlayerObjectCount = 2;

    void Start(){
        if(GameObject.FindGameObjectsWithTag("StaticTag").Length<=StaticFilesCount){
            DontDestroyOnLoad(gameObject);
        }else{  
            Destroy(gameObject);
        }
    }
    
}
