using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HouseSceneStatus : MonoBehaviour
{
    public Renderer weapon;
    public GameObject player;
    public static int SpidersKilled = 0;
    public static int maxSpiders = 5;
    public static bool CanAttack = false;
    
    void Start(){
        player = GameObject.Find("Player");
        weapon = GameObject.Find("Wand1").GetComponent<Renderer>();


        if(GameObject.FindGameObjectsWithTag("StaticTag").Length<=Statics.StaticFilesCount){
            DontDestroyOnLoad(gameObject);
        }else{  
            Destroy(gameObject);
        }

        if(SceneManager.GetActiveScene().name == "HouseScene"){
            if(SampleScene_stage.isWandTaken){
                Destroy(GameObject.FindGameObjectsWithTag("chest")[0]); 
            }
        }
    }

}





