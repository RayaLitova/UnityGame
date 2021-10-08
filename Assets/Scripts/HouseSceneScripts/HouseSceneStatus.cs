using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HouseSceneStatus : MonoBehaviour
{
    public Renderer weapon;
    public GameObject player;
    
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
                //weapon.enabled = SampleScene_stage.isWandTaken;
                //weapon.transform.parent = player.transform;
                //weapon.transform.position = (Vector2)player.transform.position + new Vector2(0.6f, -0.3f);
                //Destroy(weapon.GetComponent<BoxCollider2D>());
                //weapon.transform.Rotate(new Vector2(0,180)); 
            }
        }
    }

}





