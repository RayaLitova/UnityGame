using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class LoadScene : MonoBehaviour{
    public string SceneToLoad;
    public GameObject key;
    public GameObject player;


    void OnCollisionEnter2D(Collision2D collision){
        Statics.SceneToLoad = SceneToLoad;

        if(collision.gameObject.name == "Player"){
            if(SceneManager.GetActiveScene().name == "SampleScene" && SampleScene_stage.isKeyPicked == true){
                try{
                    if(key.scene.IsValid())
                        Destroy(key);
                }catch(Exception e){}
                SceneManager.LoadSceneAsync("LoadingScreen");
            }

            if(SceneManager.GetActiveScene().name == "HouseScene"){
                try{
                    key = GameObject.Find("web");
                    if(!key.GetComponent<Renderer>().enabled)
                        SceneManager.LoadSceneAsync("LoadingScreen");
                }catch(Exception e){
                     SceneManager.LoadSceneAsync("LoadingScreen");
                }
               

            }

                

        }

    }
        
    
}
